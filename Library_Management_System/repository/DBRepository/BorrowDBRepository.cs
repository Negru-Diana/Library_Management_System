using System.Data;
using System.Globalization;
using Library_Management_System.domain;
using Library_Management_System.repository.dbUtils;

namespace Library_Management_System.repository.DBRepository;

public class BorrowDBRepository : IRepositoryBorrow
{
    
    private readonly IDictionary<String, string> _connectionString;
    private readonly IRepositoryBook _repositoryBook;
    private readonly IRepositoryPersonForm _repositoryPersonForm;

    public BorrowDBRepository(IDictionary<String, string> connectionString, IRepositoryBook repositoryBook, IRepositoryPersonForm repositoryPersonForm)
    {
        this._connectionString = connectionString;
        this._repositoryBook = repositoryBook;
        this._repositoryPersonForm = repositoryPersonForm;
    }
    
    public Borrow FindById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Borrow> FindAll()
    {
        throw new NotImplementedException();
    }

    public void Save(Borrow entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "insert into borrowed_books (idBook, idPersonForm, borrowDate) VALUES (@idBook, @idPersonForm, @borrowDate)";
        
        AddParam(command, "@idBook", entity.Book.Id);
        AddParam(command, "@idPersonForm", entity.PersonForm.Id);
        AddParam(command, "@borrowDate", entity.BorrowDate.ToString("MM/dd/yyyy"));
        
        Console.WriteLine(entity.Book.Title);
        Console.WriteLine(entity.PersonForm.Name);
        Console.WriteLine(entity.BorrowDate.Date);
        
        command.ExecuteNonQuery();
    }

    public void Update(Borrow entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "update borrowed_books set returnDate = @returnDate where id = @id";
        
        if (entity.ReturnDate.HasValue)
        {
            AddParam(command, "@returnDate", entity.ReturnDate.Value.ToString("MM/dd/yyyy"));
        }
        else
        {
            throw new Exception("ReturnDate is null");
        }
        AddParam(command, "@id", entity.Id);

        command.ExecuteNonQuery();
    }

    public void Delete(Borrow entity)
    {
        throw new NotImplementedException();
    }


    public int GetNumberOfBorrowedCopies(int idBook)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "select count(*) from borrowed_books where idBook = @idBook and returnDate is null";

        AddParam(command, "@idBook", idBook);

        return Convert.ToInt32(command.ExecuteScalar());
    }


    public IEnumerable<Borrow> GetBorrowedCopies(PersonForm person, bool currentlyBorrowed)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        if (currentlyBorrowed)
        {
            command.CommandText = "select * from borrowed_books where idPersonForm = @idPerson and returnDate is null";
        }
        else
        {
            command.CommandText = "select * from borrowed_books where idPersonForm = @idPerson";
        }

        AddParam(command, "@idPerson", person.Id);

        List<Borrow> borrows = new List<Borrow>();

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = Convert.ToInt32(reader["id"]);
            int idBook = Convert.ToInt32(reader["idBook"]);
            string dateString = reader["borrowDate"].ToString();
            DateTime borrowDate = DateTime.ParseExact(dateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            
            Book book = _repositoryBook.FindById(idBook);
            borrows.Add(new Borrow(id,book,person,borrowDate,null));
        }

        return borrows;
    }

    private void AddParam(IDbCommand command, string name, object value)
    {
        var param = command.CreateParameter();
        param.ParameterName = name;
        param.Value = value;
        command.Parameters.Add(param);
    }
}