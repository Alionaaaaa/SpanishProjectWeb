
namespace DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity);  //creare obiect

        IQueryable<T> GetAll(); //returneaza un obiect IQueryable de tip anonim 
        //cand avem nevoie sa primim o lista de obicte dintr-un tabel
        //cand trebuie sa primim o lista dupa un anumit criteriu ex. Id, folosim: 
        //ex.var quiz = await _quizRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

        Task Delete(T entity); //sterge

        Task<T> Update(T entity); //actualizeaza
    }
}
