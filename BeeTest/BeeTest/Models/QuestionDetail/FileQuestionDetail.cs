using System.Text.Json;

namespace BeeTest.Models.QuestionDetail
{
    public class FileQuestionDetail : QuestionDetail
    {
        public string fileURL { get; set; }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
