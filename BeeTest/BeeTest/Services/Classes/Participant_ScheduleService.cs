using BeeTest.Data;
using BeeTest.Models;
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

        public async Task<List<Participant_Schedule>> GetParticipantSchedulesByScheduleId(int scheduleId)
        {
            return await _context.Participant_Schedules
                .Include(ps => ps.Participant)
                .Include(ps => ps.Schedule)
                .Where(ps => ps.Schedule.Id == scheduleId)
                .ToListAsync();
        }

        public async Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailAfter(string email, DateTime dateTime)
        {
            return await _context.Participant_Schedules
                .Include(ps => ps.Participant)
                .Include(ps => ps.Schedule)
                    .ThenInclude(s => s.Test)
                    .ThenInclude(t => t.Questions)
                .Where(ps => ps.Participant.Email == email)
                .Where(ps => ps.Schedule.StartTime > dateTime)
                .ToListAsync();
        }

        public async Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailBetween(string email, DateTime dateTime)
        {
            return await _context.Participant_Schedules
                .Include(ps => ps.Participant)
                .Include(ps => ps.Schedule)
                    .ThenInclude(s => s.Test)
                    .ThenInclude(t => t.Questions)
                .Where(ps => ps.Participant.Email == email)
                .Where(ps => ps.Schedule.StartTime <= dateTime && ps.Schedule.EndTime >= dateTime)
                .ToListAsync();
        }

        public async Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailBefore(string email, DateTime dateTime)
        {
            return await _context.Participant_Schedules
                .Include(ps => ps.Participant)
                .Include(ps => ps.Schedule)
                    .ThenInclude(s => s.Test)
                    .ThenInclude(t => t.Questions)
                .Where(ps => ps.Participant.Email == email)
                .Where(ps => ps.Schedule.EndTime < dateTime)
                .ToListAsync();
        }

        /*
         * This method initializes every question available for a particular participant_schedule, so that the test questions are finalized when the participant enters the test page for the first time. 
         * 
         * This method inserts every question of a particular test into the TemporaryAnswers table; the participant's test page will get data from that table.
         */
        public async Task<bool> InitializeTest(Participant_Schedule participant_Schedule)
        {
            List<TemporaryAnswers> temporaryAnswers = await _context.TemporaryAnswers
                .Where(ta => ta.ParticipantId == participant_Schedule.ParticipantId && ta.ScheduleId == participant_Schedule.ScheduleId)
                .ToListAsync();

            if (temporaryAnswers.Count() > 0)
            {
                return true;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach(Question question in participant_Schedule.Schedule.Test.Questions)
                    {
                        _context.TemporaryAnswers.Add(new TemporaryAnswers { 
                            Participant_Schedule = participant_Schedule,
                            Question = question,
                            Answer = "{}"
                        });
                    }

                    await transaction.CommitAsync();
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    await transaction.RollbackAsync();
                    return false;
                }
            }
        }
    }
}
