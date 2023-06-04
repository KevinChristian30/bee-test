using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IParticipant_ScheduleService
    {
        Task<bool> Add(Participant_Schedule participant_schedule);
        Task<bool> Delete(Participant_Schedule participant_Schedule);
        Task<List<Participant_Schedule>> GetParticipantSchedulesByScheduleId(int scheduleId);
        Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailAfter(string email, DateTime dateTime);
        Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailBetween(string email, DateTime dateTime);
        Task<List<Participant_Schedule>> GetParticipantSchedulesByParticipantEmailBefore(string email, DateTime dateTime);
        Task<bool> InitializeTest(Participant_Schedule participant_Schedule);
    }
}
