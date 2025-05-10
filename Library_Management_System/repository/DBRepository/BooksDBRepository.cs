using System.Data;
using Library_Management_System.domain;
using Library_Management_System.repository.dbUtils;

namespace Library_Management_System.repository.DBRepository;

public class BooksDBRepository : IRepositoryBook
{
    private readonly IDictionary<String, string> _connectionString;

    public BooksDBRepository(IDictionary<String, string> connectionString)
    {
        this._connectionString = connectionString;
    }
    
    public Book FindById(int id)
    {
        var connection = DBUtils.GetConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "select * from books where id = @id";
        
        AddParam(command, "@id", id);
        
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            int bookId = Convert.ToInt32(reader["id"]);
            string title = reader["title"].ToString();
            string author = reader["author"].ToString();
            string genre = reader["genre"].ToString();
            int quantity = Convert.ToInt32(reader["quantity"]);
            
            return new Book(bookId, title, author, genre, quantity);
        }
        return null;
    }

    public IEnumerable<Book> FindAll()
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Nu s-a putut stabili conexiunea cu baza de date.");
        }
        

        using var command = connection.CreateCommand();
        command.CommandText = "select * from books";

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            int bookId = Convert.ToInt32(reader["id"]);
            string title = reader["title"].ToString();
            string author = reader["author"].ToString();
            string genre = reader["genre"].ToString();
            int quantity = Convert.ToInt32(reader["quantity"]);
            
            books.Add(new Book(bookId, title, author, genre, quantity));
        }

        return books;
    }

    public void Save(Book entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "insert into books (title, author, genre, quantity) VALUES (@title, @author, @genre, @quantity)";
        
        AddParam(command, "@title", entity.Title);
        AddParam(command, "@author", entity.Author);
        AddParam(command, "@genre", entity.Genre);
        AddParam(command, "@quantity", entity.Quantity);
        
        command.ExecuteNonQuery();
    }

    public void Update(Book entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "update books set title = @title, author = @author, genre = @genre, quantity = @quantity where id = @id";

        
        AddParam(command, "@title", entity.Title);
        AddParam(command, "@author", entity.Author);
        AddParam(command, "@genre", entity.Genre);
        AddParam(command, "@quantity", entity.Quantity);
        AddParam(command, "@id", entity.Id);
        

        command.ExecuteNonQuery();
    }

    public void Delete(Book entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "delete from books where id = @id";

        AddParam(command, "@id", entity.Id);

        command.ExecuteNonQuery();
    }
    
    
    private void AddParam(IDbCommand command, string name, object value)
    {
        var param = command.CreateParameter();
        param.ParameterName = name;
        param.Value = value;
        command.Parameters.Add(param);
    }

    public int GetNumberOfAvailableCopies(Book book)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Book> GetBooksBySearchString(string column, string searchString)
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Nu s-a putut stabili conexiunea cu baza de date.");
        }
        

        using var command = connection.CreateCommand();
        command.CommandText = "select * from books where " + column + " like @search";
        string search = "%" + searchString + "%";
        AddParam(command, "@search", search);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            int bookId = Convert.ToInt32(reader["id"]);
            string title = reader["title"].ToString();
            string author = reader["author"].ToString();
            string genre = reader["genre"].ToString();
            int quantity = Convert.ToInt32(reader["quantity"]);
            
            books.Add(new Book(bookId, title, author, genre, quantity));
        }

        return books;
    }


    public IEnumerable<Book> GetBooksByTitle(string titleSearched)
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Nu s-a putut stabili conexiunea cu baza de date.");
        }
        

        using var command = connection.CreateCommand();
        command.CommandText = "select * from books where title = @title";
        AddParam(command, "@title", titleSearched);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            int bookId = Convert.ToInt32(reader["id"]);
            string title = reader["title"].ToString();
            string author = reader["author"].ToString();
            string genre = reader["genre"].ToString();
            int quantity = Convert.ToInt32(reader["quantity"]);
            
            books.Add(new Book(bookId, title, author, genre, quantity));
        }

        return books;
    }
}