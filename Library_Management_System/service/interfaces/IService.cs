using Library_Management_System.domain;

namespace Library_Management_System.service.interfaces;

public interface IService
{
    Book GetBookById(int id);
    IEnumerable<Book> GetAllBooks();
    void AddBook(string title, string author, string genre, int quantity);
    void DeleteBook(Book book);
    void UpdateBook(Book book);
    IEnumerable<Book> GetBooksBySearchString(string column, string searchString);
    void AddPersonForm(string name, string address, string phone, string cnp, string city, string county);
    PersonForm GetPersonFormByCnp(string cnp);
    void BorrowBooks(List<Book> books, PersonForm person);
    int GetNumberOfBorrowedCopies(int idBook);
    IEnumerable<Borrow> GetBorrowedCopies(PersonForm person);
    void ReturnBorrowedBooks(List<Borrow> borrowedBooks);
    IEnumerable<Book> GenerateBooks(int number, PersonForm person); 
}