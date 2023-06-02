using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<bool> AddOrUpdate(Question question);
        Task<List<Question>> GetQuestionsByTestId(int testId);
        Task<bool> Delete(int id);
        Task<Question> Get(int id);
    }
}
