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
    
    
    /// <summary>
    /// Retrieves a book by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the book.</param>
    /// <returns>The Book object corresponding to the provided ID.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error finding the book.</exception>
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

    
    /// <summary>
    /// Retrieves a list of all books in the library system.
    /// </summary>
    /// <returns>An IEnumerable collection of all books in the system.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error retrieving the books.</exception>
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

    
    /// <summary>
    /// Adds a new book to the library system if it doesn't already exist.
    /// </summary>
    /// <param name="title">The title of the book to be added.</param>
    /// <param name="author">The author of the book to be added.</param>
    /// <param name="genre">The genre of the book to be added.</param>
    /// <param name="quantity">The quantity of the book to be added.</param>
    /// <exception cref="Exception">Throws an exception if the book already exists or cannot be added.</exception>
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

    
    /// <summary>
    /// Deletes a specified book from the library system.
    /// </summary>
    /// <param name="book">The Book object to be deleted.</param>
    /// <exception cref="Exception">Throws an exception if the book cannot be deleted.</exception>
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

    
    /// <summary>
    /// Updates an existing book's details in the library system.
    /// </summary>
    /// <param name="book">The updated Book object.</param>
    /// <exception cref="Exception">Throws an exception if the book cannot be updated.</exception>
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

    
    /// <summary>
    /// Searches for books based on a specific column and search string.
    /// </summary>
    /// <param name="column">The column to search in (ex: "title", "author", etc.).</param>
    /// <param name="searchString">The search term to find in the specified column.</param>
    /// <returns>An IEnumerable collection of books that match the search criteria.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error retrieving books by search string.</exception>
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

    
    
    /// <summary>
    /// Generates a list of suggested books based on a person's borrowing history and preferences.
    /// Complete with random books if there aren't enough books seggested or the person haven't borrowed books yet.
    /// </summary>
    /// <param name="number">The number of books to generate.</param>
    /// <param name="person">The PersonForm object representing the person for whom books are generated.</param>
    /// <returns>An IEnumerable collection of suggested books based on the person's preferences.</returns>
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
    
    
    /// <summary>
    /// Adds a new person to the library system if they don't already exist.
    /// </summary>
    /// <param name="name">The name of the person to be added.</param>
    /// <param name="address">The address of the person to be added.</param>
    /// <param name="phone">The phone number of the person to be added.</param>
    /// <param name="cnp">The CNP of the person to be added.</param>
    /// <param name="city">The city of the person to be added.</param>
    /// <param name="county">The county of the person to be added.</param>
    /// <exception cref="Exception">Throws an exception if the person form already exists or cannot be added.</exception>
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


    /// <summary>
    /// Retrieves a person's details based on their CNP.
    /// </summary>
    /// <param name="cnp">The CNP of the person.</param>
    /// <returns>The PersonForm object representing the person with the specified CNP.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error finding the person form by CNP.</exception>
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

    
    /// <summary>
    /// Allows a person to borrow a list of books from the library system.
    /// Save the information about the borrowed books in the database.
    /// </summary>
    /// <param name="books">A list of Book objects to be borrowed.</param>
    /// <param name="person">The PersonForm object representing the person borrowing the books.</param>
    /// <exception cref="Exception">Throws an exception if there is an error borrowing the books.</exception>
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

    
    /// <summary>
    /// Retrieves the number of copies of a specific book that are currently borrowed.
    /// </summary>
    /// <param name="idBook">The unique identifier of the book.</param>
    /// <returns>The number of currently borrowed copies of the specified book.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error retrieving the number of borrowed copies.</exception>
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


    /// <summary>
    /// Retrieves a list of books currently borrowed by a specific person.
    /// </summary>
    /// <param name="person">The PersonForm object representing the person whose borrowed books are being retrieved.</param>
    /// <returns>An IEnumerable collection of Borrow objects representing the books borrowed by the person.</returns>
    /// <exception cref="Exception">Throws an exception if there is an error retrieving the books currently borrowed by the person.</exception>
    public IEnumerable<Borrow> GetBorrowedCopies(PersonForm person)
    {
        try
        {
            return _borrowRepo.GetBorrowedCopies(person, true);
        }
        catch (Exception)
        {
            throw new Exception("It occurs a problem getting the borrowed copies");
        }
    }


    /// <summary>
    /// Allows a person to return borrowed books to the library system.
    /// </summary>
    /// <param name="borrowedBooks">A list of Borrow objects representing the borrowed books being returned.</param>
    /// <exception cref="Exception">Throws an exception if there is an error returning the borrowed books.</exception>
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