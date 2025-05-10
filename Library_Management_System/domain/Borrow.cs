namespace Library_Management_System.domain;

public class Borrow : Entity<int>
{
    public Book Book { get; set; }
    public PersonForm PersonForm { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Borrow(Book book, PersonForm personForm, DateTime borrowDate, DateTime? returnDate)
    {
        this.Book = book;
        this.PersonForm = personForm;
        this.BorrowDate = borrowDate;
        this.ReturnDate = returnDate;
    }
    
    public Borrow(int Id, Book book, PersonForm personForm, DateTime borrowDate, DateTime? returnDate) : base(Id)
    {
        this.Book = book;
        this.PersonForm = personForm;
        this.BorrowDate = borrowDate;
        this.ReturnDate = returnDate;
    }
}