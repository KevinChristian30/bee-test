namespace BeeTest.Models.AnswerChecker
{
    public abstract class AnswerChecker<D, A> where D : QuestionDetail.QuestionDetail where A : Answer.Answer
    {
        public abstract bool IsCorrect(D questionDetail, A answer);
    }
}
