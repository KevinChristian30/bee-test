using BeeTest.Models.Answer;
using BeeTest.Models.QuestionDetail;

namespace BeeTest.Models.AnswerChecker
{
    public class MultipleChoiceChecker : AnswerChecker<QuestionDetail.MultipleChoiceQuestionDetail, MultipleChoiceAnswer>
    {
        public override bool IsCorrect(MultipleChoiceQuestionDetail questionDetail, MultipleChoiceAnswer answer)
        {
            return questionDetail.Key == answer.choice;
        }
    }
}
