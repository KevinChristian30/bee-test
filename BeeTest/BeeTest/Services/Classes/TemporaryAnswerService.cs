using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Pages.Admin.Users;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class TemporaryAnswerService : ITemporaryAnswerService
    {
        private DataContext _context;

        public TemporaryAnswerService(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<TemporaryAnswers>> Get(int participantId, int scheduleId)
        {
            return await _context.TemporaryAnswers
                .Include(ta => ta.Participant_Schedule)
                .Include(ta => ta.Question)
                    .ThenInclude(q => q.QuestionType)
                .Where(ta => ta.ParticipantId == participantId && ta.ScheduleId == scheduleId)
                .ToListAsync();
        }

        public async Task<bool> Update(TemporaryAnswers temporaryAnswers)
        {
            if (temporaryAnswers == null) return false;

            try
            {
                _context.TemporaryAnswers.Update(temporaryAnswers);
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
