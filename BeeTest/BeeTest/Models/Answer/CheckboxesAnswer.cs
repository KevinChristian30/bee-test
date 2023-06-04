using BeeTest.Models.QuestionDetail;
using System.Text.Json;

namespace BeeTest.Models.Answer
{
    public class CheckboxesAnswer : Answer
    {
        public Dictionary<int, bool> CheckboxQuestionData { get; set; }

        public CheckboxesAnswer()
        {
            this.CheckboxQuestionData = new Dictionary<int, bool>();
        }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
