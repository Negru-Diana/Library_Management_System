using Library_Management_System.domain;
using Library_Management_System.repository;
using Library_Management_System.service.interfaces;

namespace Library_Management_System.service;

public class Service : IService
{
    private IRepositoryBook _bookRepo;
    private IRepositoryPersonForm _personFormRepo;
    private IRepositoryBorrow _borrowRepo;

    public Service(IRepositoryBook bookRepo, IRepositoryPersonForm personFormRepo, IRepositoryBorrow borrowRepo)
    {
        this._bookRepo = bookRepo;
        this._personFormRepo = personFormRepo;
        this._borrowRepo = borrowRepo;
    }
    
    
    
    // BOOKS
    public Book GetBookById(int id)
    {
        try
        {
            return _bookRepo.FindById(id);
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem finding the book");
        }
    }

    public IEnumerable<Book> GetAllBooks()
    {
        try
        {
            return _bookRepo.FindAll();
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem finding the books");
        }
    }

    public void AddBook(string title, string author, string genre, int quantity)
    {
        Book book = new Book(title, author, genre, quantity);
        IEnumerable<Book> books = _bookRepo.GetBooksByTitle( title);
        foreach (Book b in books)
        {
            if (book.Equals(b))
            {
                throw new Exception("Book already exists");
            }
        }
        
        try
        {
            _bookRepo.Save(book);
        }
        catch (Exception)
        {
            throw new Exception("Book could not be added");
        }
    }

    public void DeleteBook(Book book)
    {
        try
        {
            _bookRepo.Delete(book);
        }
        catch (Exception)
        {
            throw new Exception("Book could not be deleted");
        }
    }

    public void UpdateBook(Book book)
    {
        try
        {
            _bookRepo.Update(book);
        }
        catch (Exception)
        {
            throw new Exception("Book could not be updated");
        }
    }

    public IEnumerable<Book> GetBooksBySearchString(string column, string searchString)
    {
        try
        {
            return _bookRepo.GetBooksBySearchString(column, searchString);
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem finding the books by search string");
        }
    }

    
    public IEnumerable<Book> GenerateBooks(int number, PersonForm person)
    {
        var allBooks = _bookRepo.FindAll().ToList();
        var borrowedBooks = _borrowRepo.GetBorrowedCopies(person, false).Select(b => b.Book).ToList();
        
        var preferredGenres = borrowedBooks.SelectMany(b => b.Genre.Split(','))
            .Select(g => g.Trim().ToLowerInvariant())
            .Distinct()
            .ToList();
        
        var preferredAuthors = borrowedBooks.SelectMany(b => b.Author.Split(','))
            .Select(a => a.Trim().ToLowerInvariant())
            .Distinct()
            .ToList();
        
        var suggested = allBooks
            .Where(b => !borrowedBooks.Contains(b) && b.Quantity - GetNumberOfBorrowedCopies(b.Id) > 0)
            .Select(b => new
            {
                Book = b,
                Score = (
                    (b.Genre.Split(',').Select(g => g.Trim().ToLowerInvariant()).Any(g => preferredGenres.Contains(g)) ? 1 : 0)
                    +
                    (b.Author.Split(',').Select(a => a.Trim().ToLowerInvariant()).Any(a => preferredAuthors.Contains(a)) ? 1 : 0)
                )
            })
            .Where(x => x.Score > 0)
            .OrderByDescending(x => x.Score)
            .ThenBy(_ => Guid.NewGuid())
            .Select(x => x.Book)
            .Take(number)
            .ToList();

        if (suggested.Count < number)
        {
            var additional = allBooks
                .Where(b => !borrowedBooks.Contains(b) &&
                            !suggested.Contains(b) &&
                            b.Quantity-GetNumberOfBorrowedCopies(b.Id) > 0)
                .OrderBy(_ => Guid.NewGuid())
                .Take(number - suggested.Count);

            suggested.AddRange(additional);
        }
        
        return suggested;
    }
    

    
    // PERSON FORMS
    
    public void AddPersonForm(string name, string address, string phone, string cnp, string city, string county)
    {
        PersonForm personForm = new PersonForm(name, address, phone, cnp, city, county);
        PersonForm findPersonForm = _personFormRepo.GetByCnp(cnp);
        if (findPersonForm != null)
        {
            throw new Exception("Person form already exists");
        }

        try
        {
            _personFormRepo.Save(personForm);
        }
        catch (Exception)
        {
            throw new Exception("Person form could not be added");
        }
    }


    public PersonForm GetPersonFormByCnp(string cnp)
    {
        try
        {
            return _personFormRepo.GetByCnp(cnp);
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem finding the person form by cnp");
        }
    }
    
    
    
    // BORROW

    public void BorrowBooks(List<Book> books, PersonForm person)
    {
        try
        {
            foreach (var book in books)
            {
                Borrow borrow = new Borrow(book, person,DateTime.Now.Date, null);
                _borrowRepo.Save(borrow);
            }
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem borrowing the books");
        }
    }

    public int GetNumberOfBorrowedCopies(int idBook)
    {
        try
        {
            return _borrowRepo.GetNumberOfBorrowedCopies(idBook);
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem getting the number of borrowed copies");
        }
        
    }


    public IEnumerable<Borrow> GetBorrowedCopies(PersonForm person)
    {
        return _borrowRepo.GetBorrowedCopies(person, true);
    }


    public void ReturnBorrowedBooks(List<Borrow> borrowedBooks)
    {
        try
        {
            foreach (var book in borrowedBooks)
            {
                book.ReturnDate = DateTime.Now.Date;
                _borrowRepo.Update(book);
            }
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem returning the borrowed books");
        }
    }
    
}