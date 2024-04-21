using DAL.Interfaces;
using Domain.Entity.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ForumRepository
{
    public class ForumMessageRepository : IBaseRepository<ForumMessage>
    {
        private readonly ApplicationDbContext _db;

        public ForumMessageRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(ForumMessage entity)
        {
            await _db.ForumMessages.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<ForumMessage> GetAll()
        {
            return _db.ForumMessages;
        }

        public async Task Delete(ForumMessage entity)
        {
            _db.ForumMessages.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ForumMessage> Update(ForumMessage entity)
        {
            _db.ForumMessages.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
