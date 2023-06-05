using BeeTest.Models.Answer;
using BeeTest.Models.QuestionDetail;

namespace BeeTest.Models.AnswerChecker
{
    public class CheckboxesChecker : AnswerChecker<CheckboxesQuestionDetail, CheckboxesAnswer>
    {
        public override bool IsCorrect(CheckboxesQuestionDetail questionDetail, CheckboxesAnswer answer)
        {
            try
            {
                foreach (var keyValuePair in answer.CheckboxQuestionData)
                {
                    if (questionDetail.CheckboxQuestionData[keyValuePair.Key].IsTrue != keyValuePair.Value)
                    {
                        return false;
                    }
                }

            } catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
