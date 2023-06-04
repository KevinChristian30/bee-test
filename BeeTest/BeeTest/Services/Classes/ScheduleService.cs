using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Pages.Users;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class ScheduleService : IScheduleService
    {
        private DataContext _context;

        public ScheduleService(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> AddOrUpdate(Schedule schedule)
        {
            if (schedule == null) return false;
            try
            {
                if (schedule.Id == 0) _context.Schedules.Add(schedule);
                else _context.Schedules.Update(schedule);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
