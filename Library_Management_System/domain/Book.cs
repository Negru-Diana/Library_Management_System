namespace Library_Management_System.domain;

public class Book : Entity<int>
{
    public string Title { get; set; }
    public string Author  { get; set; }
    public string Genre { get; set; }
    public int Quantity { get; set; }

    public Book(string title, string author, string genre, int quantity)
    {
        this.Title = title;
        this.Author = author;
        this.Genre = genre;
        this.Quantity = quantity;
    }

    public Book(int id, string title, string author, string genre, int quantity) : base(id)
    {
        this.Title = title;
        this.Author = author;
        this.Genre = genre;
        this.Quantity = quantity;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Book other)
        {
            return false;
        }
        
        return this.Title == other.Title && this.Author == other.Author && this.Genre == other.Genre;
    }
}