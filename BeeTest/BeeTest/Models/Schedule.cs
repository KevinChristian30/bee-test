namespace BeeTest.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public Test Test { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Participant_Schedule> Participant_Schedules { get; set; }
    }
}
