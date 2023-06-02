using System.Text.Json;

namespace BeeTest.Models.QuestionDetail
{
    public class BooleanQuestionDetail : QuestionDetail
    {
        public bool Key { get; set; }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
