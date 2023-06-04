using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IScheduleService
    {
        Task<bool> AddOrUpdate(Schedule schedule);
        Task<bool> Delete(int id);
        Task<Schedule> Get(int id);
        Task<List<Schedule>> Get(DateTime dateTime);
        Task<List<Schedule>> GetWithBefore(DateTime dateTime);
        Task<List<Schedule>> GetWithAfter(DateTime dateTime);
    }
}
