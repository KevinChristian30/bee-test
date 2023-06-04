using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IParticipant_ScheduleService
    {
        Task<bool> Add(Participant_Schedule participant_schedule);
        Task<List<Participant_Schedule>> GetParticipantSchedulesByScheduleId(int scheduleId);
        Task<bool> Delete(Participant_Schedule participant_Schedule);
    }
}
