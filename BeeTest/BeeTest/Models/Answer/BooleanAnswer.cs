using System.Text.Json;

namespace BeeTest.Models.Answer
{
    public class BooleanAnswer : Answer
    {
        public bool choice { get; set; }
        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
