namespace Library_Management_System.repository.dbUtils;

using System.Data;
using System.Data.SQLite;

public class SqliteConnectionFactory : ConnectionFactory
{
    public override IDbConnection CreateConnection(IDictionary<string, string> props)
    {
        String connectionString = props["ConnectionString"];
        Console.WriteLine("SQLite ---Se deschide o conexiune la  ... {0}", connectionString);
        return new SQLiteConnection(connectionString);
    }
}