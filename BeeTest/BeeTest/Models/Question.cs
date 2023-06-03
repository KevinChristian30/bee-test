using System.Text.Json.Serialization;

namespace BeeTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int QuestionPoints { get; set; }
        public Test Test { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<TemporaryAnswers> TemporaryAnswers { get; set; }
    }
}