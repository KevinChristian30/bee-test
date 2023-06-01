using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class TestService : ITestService
    {
        private readonly DataContext _context;

        public TestService(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> AddOrUpdate(Test test)
        {
            if (test == null) return false;

            try
            {
                if (test.Id == 0) _context.Tests.Add(test);
                else _context.Tests.Update(test);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var test = await Get(id);
                if (test == null) return false;

                _context.Tests.Remove(test);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public async Task<Test> Get(int id)
        {
            return await _context.Tests.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Test> Get(string name)
        {
            return await _context.Tests.FirstOrDefaultAsync(t => t.Name == name);
        }

        public async Task<List<Test>> GetAllTest()
        {
            return await _context.Tests.ToListAsync();
        }
    }
}
