namespace Library_Management_System.domain;

public class PersonForm : Entity<int>
{
    public string Name{get;set;}
    public string Address{get;set;}
    public string Phone{get;set;}
    public string Cnp{get;set;}
    public string City{get;set;}
    public string County{get;set;}
    public IEnumerable<Book> CurrentlyBorrowedBooks {get;set;}

    public PersonForm(string Name, string Address, string Phone, string Cnp, string City, string County)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
        this.Cnp = Cnp;
        this.City = City;
        this.County = County;
        this.CurrentlyBorrowedBooks = new List<Book>();
    }

    public PersonForm(string Name, string Address, string Phone, string Cnp, string City, string County,
        IEnumerable<Book> Books)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
        this.Cnp = Cnp;
        this.City = City;
        this.County = County;
        this.CurrentlyBorrowedBooks = Books;
    }
    
    public PersonForm(int Id, string Name, string Address, string Phone, string Cnp, string City, string County) : base(Id)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
        this.Cnp = Cnp;
        this.City = City;
        this.County = County;
        this.CurrentlyBorrowedBooks = new List<Book>();
    }

    public PersonForm(int Id, string Name, string Address, string Phone, string Cnp, string City, string County,
        IEnumerable<Book> Books) : base(Id)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
        this.Cnp = Cnp;
        this.City = City;
        this.County = County;
        this.CurrentlyBorrowedBooks = Books;
    }
    
}