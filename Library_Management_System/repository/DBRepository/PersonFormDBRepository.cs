using System.Data;
using Library_Management_System.domain;
using Library_Management_System.repository.dbUtils;

namespace Library_Management_System.repository.DBRepository;

public class PersonFormDBRepository: IRepositoryPersonForm
{
    private readonly IDictionary<String, string> _connectionString;

    public PersonFormDBRepository(IDictionary<String, string> connectionString)
    {
        this._connectionString = connectionString;
    }

    public PersonForm FindById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PersonForm> FindAll()
    {
        throw new NotImplementedException();
    }

    
    /// <summary>
    /// Saves a new person form record to the database.
    /// </summary>
    /// <param name="entity">The person form entity to be saved.</param>
    public void Save(PersonForm entity)
    {
        var connection = DBUtils.GetConnection(_connectionString);

        using var command = connection.CreateCommand();
        command.CommandText = "insert into person_forms (name, address, phone, cnp, city, county) VALUES (@name, @address, @phone, @cnp, @city, @county)";
        
        AddParam(command, "@name", entity.Name);
        AddParam(command, "@address", entity.Address);
        AddParam(command, "@phone", entity.Phone);
        AddParam(command, "@cnp", entity.Cnp);
        AddParam(command, "@city", entity.City);
        AddParam(command, "@county", entity.County);
        
        command.ExecuteNonQuery();
    }

    public void Update(PersonForm entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(PersonForm entity)
    {
        throw new NotImplementedException();
    }

    
    
    /// <summary>
    /// Retrieves a person form based on a specific CNP.
    /// </summary>
    /// <param name="cnpSearch">The CNP to search for.</param>
    /// <returns>The person form with the specified CNP, or null if not found.</returns>
    public PersonForm GetByCnp(string cnpSearch)
    {
        var connection = DBUtils.GetConnection(_connectionString);
        using var command = connection.CreateCommand();
        command.CommandText = "select * from person_forms where cnp = @cnp";
        
        AddParam(command, "@cnp", cnpSearch);
        
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            int id = Convert.ToInt32(reader["id"]);
            string name = reader["name"].ToString();
            string address = reader["address"].ToString();
            string phone = reader["phone"].ToString();
            string cnp = reader["cnp"].ToString();
            string city = reader["city"].ToString();
            string county = reader["county"].ToString();
            
            return new PersonForm(id, name, address, phone, cnp, city, county);
        }
        return null;
    }
    
    
    /// <summary>
    /// Adds a parameter with its value to a database command.
    /// </summary>
    /// <param name="command">The command to which the parameter will be added.</param>
    /// <param name="name">The name of the parameter (ex: @cnp).</param>
    /// <param name="value">The value of the parameter.</param>
    private void AddParam(IDbCommand command, string name, object value)
    {
        var param = command.CreateParameter();
        param.ParameterName = name;
        param.Value = value;
        command.Parameters.Add(param);
    }
}