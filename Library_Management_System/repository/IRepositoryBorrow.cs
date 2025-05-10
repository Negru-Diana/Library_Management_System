using Library_Management_System.domain;

namespace Library_Management_System.repository;

public interface IRepositoryBorrow : IRepository<int, Borrow>
{
    int GetNumberOfBorrowedCopies(int idBook);
    IEnumerable<Borrow> GetBorrowedCopies(PersonForm person, bool currentlyBorrowed);
}