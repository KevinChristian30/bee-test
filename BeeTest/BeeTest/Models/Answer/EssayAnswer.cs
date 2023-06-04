using System.Text.Json;

namespace BeeTest.Models.Answer
{
    public class EssayAnswer : Answer
    {
        public string answer { get; set; }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
