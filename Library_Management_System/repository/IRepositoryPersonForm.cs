using Library_Management_System.domain;

namespace Library_Management_System.repository;

public interface IRepositoryPersonForm : IRepository<int, PersonForm>
{
    PersonForm GetByCnp(string cnp);
}