using Library_Management_System.domain;

namespace Library_Management_System.repository;

public interface IRepositoryBook : IRepository<int, Book>
{
    IEnumerable<Book> GetBooksBySearchString(string column, string searchString);
    IEnumerable<Book> GetBooksByTitle(string titleSearched);
}