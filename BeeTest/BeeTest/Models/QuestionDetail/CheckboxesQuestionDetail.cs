using System.Text.Json;

namespace BeeTest.Models.QuestionDetail
{
    public class CheckboxesQuestionDetail : QuestionDetail
    {
        public class Data
        {
            public bool IsTrue { get; set; }
            public string Statement { get; set; }
        }

        public Dictionary<int, Data> CheckboxQuestionData { get; set; }

        public CheckboxesQuestionDetail()
        {
            this.CheckboxQuestionData  = new Dictionary<int, Data>();
        }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
