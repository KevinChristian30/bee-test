namespace BeeTest.Models
{
    public class Participant_Schedule
    {
        public int ParticipantId { get; set; }
        public int ScheduleId { get; set; }
        public Participant Participant { get; set; }
        public Schedule Schedule { get; set; }
        public string Details { get; set; }
        public ICollection<TemporaryAnswers> TemporaryAnswers { get; set; }
    }
}
