using BeeTest.Models.Answer;
using BeeTest.Models.QuestionDetail;

namespace BeeTest.Models.AnswerChecker
{
    public class BooleanChecker : AnswerChecker<BooleanQuestionDetail, BooleanAnswer>
    {
        public override bool IsCorrect(BooleanQuestionDetail questionDetail, BooleanAnswer answer)
        {
            return questionDetail.Key == answer.choice;
        }
    }
}
