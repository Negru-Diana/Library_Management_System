using Library_Management_System.domain;
using Library_Management_System.service.interfaces;
using Library_Management_System.utils.events;

namespace Library_Management_System.service;

public class ObservableService : IService, utils.observer.IObservable<IEvent>, IObservableService
{
    private IService _service;
    private readonly List<utils.observer.IObserver<IEvent>> _observers = new();

    public ObservableService(IService service)
    {
        this._service = service;
    }
    
    
    // OBSERVER
    
    
    /// <summary>
    /// Adds an observer to the list of observers to be notified when an event occurs.
    /// </summary>
    /// <param name="observer">An object implementing the IObserver<IEvent> interface to be added to the observers list.</param>
    public void AddObserver(utils.observer.IObserver<IEvent> observer)
    {
        _observers.Add(observer);
    }

    
    /// <summary>
    /// Removes an observer from the list of observers so it no longer receives notifications.
    /// </summary>
    /// <param name="observer">An object implementing the IObserver<IEvent> interface to be removed from the observers list.</param>
    public void RemoveObserver(utils.observer.IObserver<IEvent> observer)
    {
        _observers.Remove(observer);
    }

    
    /// <summary>
    /// Notifies all registered observers with the specified event data.
    /// </summary>
    /// <param name="eventData">An event that implements the IEvent interface, which will be passed to all observers.</param>
    public void NotifyObservers(IEvent eventData)
    {
        foreach (var observer in _observers)
        {
            observer.Update(eventData);
        }
    }
    
    
    // BOOKS

    
    /// <summary>
    /// Retrieves a book by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the book.</param>
    /// <returns>A Book object corresponding to the provided ID.</returns>
    public Book GetBookById(int id) => _service.GetBookById(id);

    
    /// <summary>
    /// Retrieves a list of all books in the system.
    /// </summary>
    /// <returns>An IEnumerable collection of all books.</returns>
    public IEnumerable<Book> GetAllBooks() => _service.GetAllBooks();
   

    /// <summary>
    /// Adds a new book to the library system.
    /// </summary>
    /// <param name="title">The title of the book to be added.</param>
    /// <param name="author">The author of the book to be added.</param>
    /// <param name="genre">The genre of the book to be added.</param>
    /// <param name="quantity">The quantity of copies of the book to be added.</param>
    public void AddBook(string title, string author, string genre, int quantity)
    {
        _service.AddBook(title, author, genre, quantity);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.AddBook, null));
    }

    
    /// <summary>
    /// Deletes a specific book from the library system and notify all observers about this.
    /// </summary>
    /// <param name="book">The Book object to be deleted.</param>
    public void DeleteBook(Book book)
    {
        _service.DeleteBook(book);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.DeleteBook, null));
    }


    /// <summary>
    /// Updates an existing book's details in the library system and notify all observers about this.
    /// </summary>
    /// <param name="book">The updated Book object.</param>
    public void UpdateBook(Book book)
    {
        _service.UpdateBook(book);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.UpdateBook, book));
    }

    
    /// <summary>
    /// Searches for books based on a specific column and search string.
    /// </summary>
    /// <param name="column">The column to search in (ex: "title", "author", etc.).</param>
    /// <param name="searchString">The search term to find in the specified column.</param>
    /// <returns>An IEnumerable collection of books that match the search criteria.</returns>
    public IEnumerable<Book> GetBooksBySearchString(string column, string searchString) => _service.GetBooksBySearchString(column, searchString);
    
    
    /// <summary>
    /// Generates a specified number of books for a given person.
    /// </summary>
    /// <param name="number">The number of books to generate.</param>
    /// <param name="person">The PersonForm object representing the person for whom books are generated.</param>
    /// <returns>An IEnumerable collection of generated books.</returns>
    public IEnumerable<Book> GenerateBooks(int number, PersonForm person) => _service.GenerateBooks(number, person);


    
    /// <summary>
    /// Notifies observers that the book must be moved in the list of books to borrow.
    /// </summary>
    /// <param name="books">A collection of Book objects to be moved.</param>
    /// <exception cref="Exception">If any problem occurs while trying to move the books.</exception>
    public void MoveBooks(IEnumerable<Book> books)
    {
        try
        {
            foreach (var book in books)
            {
                NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.MoveBook, book));
            }
        }
        catch (Exception e)
        {
            throw new Exception("It occurs a problem while moving books.", e);
        }
    }


    // PERSON FORMS

    
    /// <summary>
    /// Adds a new person to the system.
    /// </summary>
    /// <param name="name">The name of the person to be added.</param>
    /// <param name="address">The address of the person to be added.</param>
    /// <param name="phone">The phone number of the person to be added.</param>
    /// <param name="cnp">The CNP of the person to be added.</param>
    /// <param name="city">The city of the person to be added.</param>
    /// <param name="county">The county of the person to be added.</param>
    public void AddPersonForm(string name, string address, string phone, string cnp, string city, string county)
    {
        _service.AddPersonForm(name, address, phone, cnp, city, county);
        NotifyObservers(new EntityChangeEvent<PersonForm>(ChangeEventType.AddPersonForm, null));
    }
    
    
    /// <summary>
    /// Retrieves a person's details based on their CNP.
    /// </summary>
    /// <param name="cnp">The CNP of the person.</param>
    /// <returns>A PersonForm object representing the person with the specified CNP.</returns>
    public PersonForm GetPersonFormByCnp(string cnp) => _service.GetPersonFormByCnp(cnp);


    
    // BORROW
    
    
    /// <summary>
    /// Allows a person to borrow a list of books from the library system.
    /// </summary>
    /// <param name="books">>A list of Book objects to be borrowed.</param>
    /// <param name="person">The PersonForm object representing the person borrowing the books.</param>
    public void BorrowBooks(List<Book> books, PersonForm person)
    {
        _service.BorrowBooks(books, person);
        NotifyObservers(new EntityChangeEvent<Borrow>(ChangeEventType.BorrowBooks, null));
    }

    
    /// <summary>
    /// Retrieves the number of copies of a specific book that are currently borrowed.
    /// </summary>
    /// <param name="idBook">The unique identifier of the book.</param>
    /// <returns>The number of currently borrowed copies of the specified book.</returns>
    public int GetNumberOfBorrowedCopies(int idBook) => _service.GetNumberOfBorrowedCopies(idBook);


    /// <summary>
    /// Retrieves a list of books that are currently borrowed by a specific person.
    /// </summary>
    /// <param name="person">The PersonForm object representing the person whose borrowed books are being retrieved.</param>
    /// <returns>An IEnumerable collection of Borrow objects representing the books currently borrowed by the person.</returns>
    public IEnumerable<Borrow> GetBorrowedCopies(PersonForm person) => _service.GetBorrowedCopies(person);

    
    
    /// <summary>
    /// Allows a person to return borrowed books to the library system and notify all the observers about this.
    /// </summary>
    /// <param name="borrowedBooks">A list of Borrow objects representing the borrowed books being returned.</param>
    public void ReturnBorrowedBooks(List<Borrow> borrowedBooks)
    {
        _service.ReturnBorrowedBooks(borrowedBooks);
        NotifyObservers(new EntityChangeEvent<Borrow>(ChangeEventType.ReturnBooks, null));
    }
    
}