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
    
    
    /// <summary>
    /// Finds and returns a book by ID.
    /// </summary>
    /// <param name="id">The ID of the book to find.</param>
    /// <returns>The Book object with the specified ID, or null if not found.</returns>
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

    
    
    /// <summary>
    /// Retrieves all books from the database.
    /// </summary>
    /// <returns>A list of all books in the database.</returns>
    /// <exception cref="Exception">If the connection to the database failed.</exception>
    public IEnumerable<Book> FindAll()
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Couldn't establish database connection.");
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

    
    /// <summary>
    /// Saves a new book to the database.
    /// </summary>
    /// <param name="entity">The Book object to be saved.</param>
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

    
    /// <summary>
    /// Updates the information of an existing book in the database.
    /// </summary>
    /// <param name="entity">The Book object with updated information.</param>
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

    
    /// <summary>
    /// Deletes a book from the database.
    /// </summary>
    /// <param name="entity">The Book object to be deleted.</param>
    public void Delete(Book entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "delete from books where id = @id";

        AddParam(command, "@id", entity.Id);

        command.ExecuteNonQuery();
    }
    
    
    
    /// <summary>
    /// Adds a parameter to an IDbCommand object.
    /// </summary>
    /// <param name="command">The command to which the parameter will be added.</param>
    /// <param name="name">The name of the parameter (ex: @id).</param>
    /// <param name="value">The value of the parameter.</param>
    private void AddParam(IDbCommand command, string name, object value)
    {
        var param = command.CreateParameter();
        param.ParameterName = name;
        param.Value = value;
        command.Parameters.Add(param);
    }

    
    /// <summary>
    /// Retrieves books that contain a given search string in a specific column.
    /// </summary>
    /// <param name="column">The column to search in (ex: "title").</param>
    /// <param name="searchString">The string to search for in the column.</param>
    /// <returns>A list of books matching the search criteria.</returns>
    /// <exception cref="Exception">If the connection to the database failed</exception>
    public IEnumerable<Book> GetBooksBySearchString(string column, string searchString)
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Couldn't establish database connection.");
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


    /// <summary>
    /// Retrieves books with an exact match on the title.
    /// </summary>
    /// <param name="titleSearched">The title to search for.</param>
    /// <returns>A list of books with the exact title.</returns>
    /// <exception cref="Exception">If the connection to the database failed.</exception>
    public IEnumerable<Book> GetBooksByTitle(string titleSearched)
    {
        var books = new List<Book>();
        var connection = DBUtils.GetConnection(_connectionString);
        if (connection == null)
        {
            throw new Exception("Couldn't establish database connection.");
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