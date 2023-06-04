using BeeTest.Models;
using BeeTest.Services.Classes;

namespace BeeTest.Services.Interfaces
{
    public interface ITemporaryAnswerService
    {
        Task<List<TemporaryAnswers>> Get(int participantId, int scheduleId);
        Task<bool> Update(TemporaryAnswers temporaryAnswers);
    }
}
