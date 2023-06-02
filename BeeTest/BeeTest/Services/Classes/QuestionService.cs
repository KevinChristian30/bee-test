using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Pages.Users;
using BeeTest.Services.Interfaces;

namespace BeeTest.Services.Classes
{
    public class QuestionService : IQuestionService
    {
        private readonly DataContext _context;

        public QuestionService(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> AddOrUpdate(Question question)
        {
            if (question == null) return false;

            try
            {
                if (question.Id == 0) _context.Questions.Add(question);
                else _context.Questions.Update(question);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
