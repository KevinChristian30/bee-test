namespace BeeTest.Models
{
    public class TemporaryAnswers
    {
        public int ParticipantId { get; set; }
        public int ScheduleId { get; set; }
        public int QuestionId { get; set; }
        public Participant_Schedule Participant_Schedule { get; set; }
        public Question Question { get; set; }
        public string Answer { get; set; }
    }
}