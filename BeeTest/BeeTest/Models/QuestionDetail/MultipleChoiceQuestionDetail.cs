using System.Text.Json;

namespace BeeTest.Models.QuestionDetail
{
    public class MultipleChoiceQuestionDetail : QuestionDetail
    {
        public Dictionary<char, string> Choices { get; set; }
        public char Key { get; set; }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
