using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Pages.Users;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class Participant_ScheduleService : IParticipant_ScheduleService
    {
        private readonly DataContext _context;

        public Participant_ScheduleService(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> Add(Participant_Schedule participant_schedule)
        {
            if (participant_schedule == null) return false;

            try
            {
                _context.Participant_Schedules.Add(participant_schedule);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        
        public async Task<List<Participant_Schedule>> GetParticipantSchedulesByScheduleId(int scheduleId)
        {
            return await _context.Participant_Schedules
                .Include(ps => ps.Participant)
                .Include(ps => ps.Schedule)
                .Where(ps => ps.Schedule.Id == scheduleId)
                .ToListAsync();
        }
        public async Task<bool> Delete(Participant_Schedule participant_Schedule)
        {
            try
            {
                _context.Participant_Schedules.Remove(participant_Schedule);
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
