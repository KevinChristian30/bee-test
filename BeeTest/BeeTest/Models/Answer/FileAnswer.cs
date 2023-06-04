using System.Text.Json;

namespace BeeTest.Models.Answer
{
    public class FileAnswer : Answer
    {
        public string link { get; set; }

        public override string ToJSONString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
