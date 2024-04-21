using DAL.Interfaces;
using Domain.Entity.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QuizRepository : IBaseRepository<Quiz>
    {
        private readonly ApplicationDbContext _db;

        public QuizRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Quiz entity)
        {
            await _db.Quizes.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Quiz> GetAll()
        {
            return _db.Quizes;
        }

        public async Task Delete(Quiz entity)
        {
            _db.Quizes.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Quiz> Update(Quiz entity)
        {
            _db.Quizes.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
