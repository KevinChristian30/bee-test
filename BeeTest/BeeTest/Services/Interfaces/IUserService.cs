using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddOrUpdate(User user);
        Task<bool> Delete(int id);
        Task<User> Get(int id);
        Task<User> Get(string email);
        Task<List<User>> GetAllParticipants();
    }
}
