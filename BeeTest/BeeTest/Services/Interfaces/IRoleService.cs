using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IRoleService
    {
        Role Get(string Name);
        Role Get(int id);
        ICollection<Role> GetAll();
    }
}
