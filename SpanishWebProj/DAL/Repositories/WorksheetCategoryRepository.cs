using DAL.Interfaces;
using Domain.Entity.Worksheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class WorksheetCategoryRepository : IBaseRepository<WorksheetCategory>
    {
        private readonly ApplicationDbContext _db;

        public WorksheetCategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(WorksheetCategory entity)
        {
            await _db.WorksheetCategory.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<WorksheetCategory> GetAll()
        {
            return _db.WorksheetCategory;
        }

        public async Task Delete(WorksheetCategory entity)
        {
            _db.WorksheetCategory.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<WorksheetCategory> Update(WorksheetCategory entity)
        {
            _db.WorksheetCategory.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}

