using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface ITestService
    {
        Task<bool> AddOrUpdate(Test test);
        Task<bool> Delete(int id);
        Task<Test> Get(int id);
        Task<Test> Get(string name);
        Task<List<Test>> GetAllTests();
    }
}
