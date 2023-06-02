using BeeTest.Models;

namespace BeeTest.Services.Interfaces
{
    public interface IQuestionTypeService
    {
        Task<List<QuestionType>> GetAllQuestionTypes();
        Task<QuestionType> Get(string name);
    }
}
