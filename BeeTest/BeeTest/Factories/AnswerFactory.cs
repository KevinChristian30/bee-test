using BeeTest.Models.Answer;
using System.Text.Json;

namespace BeeTest.Factories
{
    public class AnswerFactory
    {
        public static Answer ParseJSON(string answerTypeName, string json)
        {
            try
            {
                if (answerTypeName == "Multiple Choice") return JsonSerializer.Deserialize<MultipleChoiceAnswer>(json);

                if (answerTypeName == "Boolean") return JsonSerializer.Deserialize<BooleanAnswer>(json);

                if (answerTypeName == "Checkboxes") return JsonSerializer.Deserialize<CheckboxesAnswer>(json);

                if (answerTypeName == "Essay") return JsonSerializer.Deserialize<EssayAnswer>(json);

                if (answerTypeName == "File") return JsonSerializer.Deserialize<FileAnswer>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
