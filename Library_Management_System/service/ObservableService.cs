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
    public void AddObserver(utils.observer.IObserver<IEvent> observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(utils.observer.IObserver<IEvent> observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(IEvent eventData)
    {
        foreach (var observer in _observers)
        {
            observer.Update(eventData);
        }
    }
    
    
    // BOOKS

    public Book GetBookById(int id) => _service.GetBookById(id);

    public IEnumerable<Book> GetAllBooks() => _service.GetAllBooks();
   

    public void AddBook(string title, string author, string genre, int quantity)
    {
        _service.AddBook(title, author, genre, quantity);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.AddBook, null));
    }

    public void DeleteBook(Book book)
    {
        _service.DeleteBook(book);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.DeleteBook, null));
    }


    public void UpdateBook(Book book)
    {
        _service.UpdateBook(book);
        NotifyObservers(new EntityChangeEvent<Book>(ChangeEventType.UpdateBook, book));
    }

    public IEnumerable<Book> GetBooksBySearchString(string column, string searchString) => _service.GetBooksBySearchString(column, searchString);
    
    
    public IEnumerable<Book> GenerateBooks(int number, PersonForm person) => _service.GenerateBooks(number, person);


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

    public void AddPersonForm(string name, string address, string phone, string cnp, string city, string county)
    {
        _service.AddPersonForm(name, address, phone, cnp, city, county);
        NotifyObservers(new EntityChangeEvent<PersonForm>(ChangeEventType.AddPersonForm, null));
    }
    
    public PersonForm GetPersonFormByCnp(string cnp) => _service.GetPersonFormByCnp(cnp);


    
    // BORROW
    
    public void BorrowBooks(List<Book> books, PersonForm person)
    {
        _service.BorrowBooks(books, person);
        NotifyObservers(new EntityChangeEvent<Borrow>(ChangeEventType.BorrowBooks, null));
    }

    public int GetNumberOfBorrowedCopies(int idBook) => _service.GetNumberOfBorrowedCopies(idBook);


    public IEnumerable<Borrow> GetBorrowedCopies(PersonForm person) => _service.GetBorrowedCopies(person);

    
    public void ReturnBorrowedBooks(List<Borrow> borrowedBooks)
    {
        _service.ReturnBorrowedBooks(borrowedBooks);
        NotifyObservers(new EntityChangeEvent<Borrow>(ChangeEventType.ReturnBooks, null));
    }
    
    
    
}