using System.Text.Json;

namespace BeeTest.Models.Answer
{
    public class MultipleChoiceAnswer : Answer
    {
        public char choice { get; set; }
        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
