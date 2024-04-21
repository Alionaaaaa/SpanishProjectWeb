using DAL.Interfaces;
using Domain.Entity;

namespace DAL.Repositories
{
    public class CourseRepository : IBaseRepository<Course>
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Course entity)
        {
            await _db.Courses.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Course> GetAll()
        {
            return _db.Courses;
        }

        public async Task Delete(Course entity)
        {
            _db.Courses.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Course> Update(Course entity)
        {
            _db.Courses.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
