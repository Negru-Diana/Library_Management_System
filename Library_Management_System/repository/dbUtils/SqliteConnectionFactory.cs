namespace Library_Management_System.repository.dbUtils;

using System.Data;
using System.Data.SQLite;

public class SqliteConnectionFactory : ConnectionFactory
{
    
    /// <summary>
    /// Creates a new SQLiteConnection using the provided configuration properties.
    /// </summary>
    /// <param name="props">A dictionary containing configuration properties. Must include a key "ConnectionString" with the valid SQLite connection string.</param>
    /// <returns>A new instance of SQLiteConnection.</returns>
    public override IDbConnection CreateConnection(IDictionary<string, string> props)
    {
        String connectionString = props["ConnectionString"];
        //Console.WriteLine("SQLite ---Se deschide o conexiune la  ... {0}", connectionString);
        return new SQLiteConnection(connectionString);
    }
}