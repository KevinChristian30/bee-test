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
            } catch (Exception _)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var user = await Get(id);
                if (user == null) return false;

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                
                return true;
            } catch (Exception _)
            {
                return false;
            }
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> Get(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<ICollection<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
