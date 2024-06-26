﻿using BeeTest.Data;
using BeeTest.Models;
using BeeTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public async Task<bool> Delete(int id)
        {
            try
            {
                var question = await Get(id);
                if (question == null) return false;

                _context.Questions.Remove(question);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public async Task<Question> Get(int id)
        {
            return await _context.Questions
                .Include(q => q.QuestionType)
                .Where(q => q.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Question>> GetQuestionsByTestId(int testId)
        {
            return await _context.Questions
                .Include(q => q.Test)
                .Include(q => q.QuestionType)
                .Where(q => q.Test.Id == testId)
                .ToListAsync();
        }
    }
}