using DAL.Interfaces;
using Domain.Entity.Vocabulary;

namespace DAL.Repositories
{
    public class VocabularyRepository : IBaseRepository<AudioLesson>
    {
        private readonly ApplicationDbContext _db;

        public VocabularyRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(AudioLesson entity)
        {
            await _db.AudioLessons.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<AudioLesson> GetAll()
        {
            return _db.AudioLessons;
        }

        public async Task Delete(AudioLesson entity)
        {
            _db.AudioLessons.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<AudioLesson> Update(AudioLesson entity)
        {
            _db.AudioLessons.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
