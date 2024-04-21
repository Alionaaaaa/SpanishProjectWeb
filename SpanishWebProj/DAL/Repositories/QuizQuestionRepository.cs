using DAL.Interfaces;
using Domain.Entity.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QuizQuestionRepository : IBaseRepository<QuizQuestion>
    {
        private readonly ApplicationDbContext _db;

        public QuizQuestionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(QuizQuestion entity)
        {
            await _db.QuizQuestions.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<QuizQuestion> GetAll()
        {
            return _db.QuizQuestions;
        }

        public async Task Delete(QuizQuestion entity)
        {
            _db.QuizQuestions.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<QuizQuestion> Update(QuizQuestion entity)
        {
            _db.QuizQuestions.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
