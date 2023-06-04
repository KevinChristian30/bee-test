using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IScheduleService
    {
        Task<bool> AddOrUpdate(Schedule schedule);
    }
}
