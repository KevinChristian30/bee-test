namespace BeeTest.Models
{
    public class QuestionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
