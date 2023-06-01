using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> AddOrUpdate(User user)
        {
            if (user == null) return false;
            
            try
            {
                if (user.Id == 0) _context.Users.Add(user);
                else _context.Users.Update(user);

                await _context.SaveChangesAsync();

                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users
                .Include(user => user.Role)
                .Where(u => u.DeletedAt == null)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> Get(string email)
        {
            return await _context.Users
                .Include(user => user.Role)
                .Where(u => u.DeletedAt == null)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<User>> GetAllParticipants()
        {
            return await _context.Users
                .Include(user => user.Role)
                .Where(u => u.Role.Name == "Participant")
                .Where(u => u.DeletedAt == null)
                .ToListAsync();
        }
    }
}
