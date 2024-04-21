using DAL.Interfaces;
using Domain.Entity;
using Domain.Entity.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ForumRepository
{
    public class ForumCategoryRepository : IBaseRepository<ForumCategory>
    {
        private readonly ApplicationDbContext _db;

        public ForumCategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(ForumCategory entity)
        {
            await _db.ForumCategories.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<ForumCategory> GetAll()
        {
            return _db.ForumCategories;
        }

        public async Task Delete(ForumCategory entity)
        {
            _db.ForumCategories.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ForumCategory> Update(ForumCategory entity)
        {
            _db.ForumCategories.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
