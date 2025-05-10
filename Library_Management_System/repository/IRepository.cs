using Library_Management_System.domain;

namespace Library_Management_System.repository;

public interface IRepository<TId, TE> where TE : Entity<TId>
{
    TE FindById(int id);
    IEnumerable<TE> FindAll();
    void Save(TE entity);
    void Update(TE entity);
    void Delete(TE entity);
}