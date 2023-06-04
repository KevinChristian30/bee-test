using BeeTest.Data;
using BeeTest.Models;
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

        public async Task<bool> Delete(int id)
        {
            try
            {
                var schedule = await Get(id);
                if (schedule == null) return false;

                _context.Schedules.Remove(schedule);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public async Task<Schedule> Get(int id)
        {
            return await _context.Schedules
                .Include(s => s.Test)
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Schedule>> Get(DateTime dateTime)
        {
            return await _context.Schedules
                .Include(s => s.Test)
                .Where(s => s.StartTime.Date == dateTime.Date)
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetWithAfter(DateTime dateTime)
        {
            return await _context.Schedules
                .Include(s => s.Test)
                .Where(s => s.StartTime.Date >= dateTime.Date)
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetWithBefore(DateTime dateTime)
        {
            return await _context.Schedules
                .Include(s => s.Test)
                .Where(s => s.StartTime.Date <= dateTime.Date)
                .ToListAsync();
        }
    }
}
