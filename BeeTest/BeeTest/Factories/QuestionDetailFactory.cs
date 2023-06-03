using BeeTest.Models.QuestionDetail;
using System.Text.Json;

namespace BeeTest.Factories
{
    public class QuestionDetailFactory
    {
        public static QuestionDetail ParseJSON(string questionTypeName, string json)
        {
            try
            {
                if (questionTypeName == "Multiple Choice") return JsonSerializer.Deserialize<MultipleChoiceQuestionDetail>(json);

                if (questionTypeName == "Boolean") return JsonSerializer.Deserialize<BooleanQuestionDetail>(json);

                if (questionTypeName == "Checkboxes") return JsonSerializer.Deserialize<CheckboxesQuestionDetail>(json);

                if (questionTypeName == "File") return JsonSerializer.Deserialize<FileQuestionDetail>(json);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
