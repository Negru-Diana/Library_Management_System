namespace Library_Management_System.repository.dbUtils;

using System.Data;

public class DBUtils
{
    private static IDbConnection _instance = null;


    /// <summary>
    /// Retrieves a singleton database connection using the provided configuration properties.
    /// If no connection exists or the existing one is closed, a new connection is created and opened.
    /// </summary>
    /// <param name="props">A dictionary containing database configuration properties (ex: connection string, provider name).</param>
    /// <returns>An open</returns>
    public static IDbConnection GetConnection(IDictionary<string,string> props)
    {
        if (_instance == null || _instance.State == ConnectionState.Closed)
        {
            _instance = GetNewConnection(props);
            _instance.Open();
        }
        return _instance;
    }

    
    /// <summary>
    /// Creates a new database connection using the ConnectionFactory.
    /// </summary>
    /// <param name="props">A dictionary containing database configuration properties.</param>
    /// <returns>An instance.</returns>
    private static IDbConnection GetNewConnection(IDictionary<string,string> props)
    {
        return ConnectionFactory.GetInstance().CreateConnection(props);
    }
}