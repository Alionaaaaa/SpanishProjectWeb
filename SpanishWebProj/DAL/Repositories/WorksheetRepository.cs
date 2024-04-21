using DAL.Interfaces;
using Domain.Entity;
using Domain.Entity.Worksheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class WorksheetRepository : IBaseRepository<Worksheet>
    {
        private readonly ApplicationDbContext _db;

        public WorksheetRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Worksheet entity)
        {
            await _db.Worksheets.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Worksheet> GetAll()
        {
            return _db.Worksheets;
        }

        public async Task Delete(Worksheet entity)
        {
            _db.Worksheets.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Worksheet> Update(Worksheet entity)
        {
            _db.Worksheets.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}

