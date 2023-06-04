using System.Text.Json;

namespace BeeTest.Models.QuestionDetail
{
    public class CheckboxesQuestionDetail : QuestionDetail
    {
        public Dictionary<int, CheckboxData> CheckboxQuestionData { get; set; }

        public CheckboxesQuestionDetail()
        {
            this.CheckboxQuestionData  = new Dictionary<int, CheckboxData>();
        }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
