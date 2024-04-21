using DAL.Interfaces;
using Domain.Entity.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ForumRepository
{
    public class ForumTopicRepository : IBaseRepository<ForumTopic>
    {
        private readonly ApplicationDbContext _db;

        public ForumTopicRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(ForumTopic entity)
        {
            await _db.ForumTopics.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<ForumTopic> GetAll()
        {
            return _db.ForumTopics;
        }

        public async Task Delete(ForumTopic entity)
        {
            _db.ForumTopics.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ForumTopic> Update(ForumTopic entity)
        {
            _db.ForumTopics.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
