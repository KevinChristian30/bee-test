namespace BeeTest.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassingScore { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
