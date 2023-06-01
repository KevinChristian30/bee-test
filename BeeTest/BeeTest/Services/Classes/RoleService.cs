using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class RoleService : IRoleService
    {
        private readonly DataContext _context;
        public RoleService(DataContext context)
        {
            this._context = context;
        }
        public Role Get(string name)
        {
            return _context.Roles.FirstOrDefault(r => r.Name == name);
        }
    }
}
