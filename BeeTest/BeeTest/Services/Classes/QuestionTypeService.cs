using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeTest.Services.Classes
{
    public class QuestionTypeService : IQuestionTypeService
    {
        private readonly DataContext _context;

        public QuestionTypeService(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<QuestionType>> GetAllQuestionTypes()
        {
            return await _context.QuestionTypes.ToListAsync();
        }

        public async Task<QuestionType> Get(string name)
        {
            return await _context.QuestionTypes.FirstOrDefaultAsync(qt => qt.Name == name);
        }

    }
}
