namespace Library_Management_System.repository.dbUtils;

using System.Data;
using System.Reflection;
public abstract class ConnectionFactory
{
    protected ConnectionFactory()
    {
    }

    private static ConnectionFactory instance;

    
    /// <summary>
    /// Gets the singleton instance of a ConnectionFactory subclass.
    ///  Automatically searches for and creates the first available subclass in the current assembly.
    /// </summary>
    /// <returns>An instance of a subclass of ConnectionFactory.</returns>
    public static ConnectionFactory GetInstance()
    {
        if (instance == null)
        {

            Assembly assem = Assembly.GetExecutingAssembly();
            Type[] types = assem.GetTypes();
            foreach (var type in types)
            {
                if (type.IsSubclassOf(typeof(ConnectionFactory)))
                    instance = (ConnectionFactory)Activator.CreateInstance(type);
            }
        }
        return instance;
    }

    
    /// <summary>
    /// Abstract method that must be implemented by subclasses to create a database connection.
    /// </summary>
    /// <param name="props">A dictionary containing database configuration properties (ex: connection string, provider name).</param>
    /// <returns>An open</returns>
    public abstract  IDbConnection CreateConnection(IDictionary<string,string> props);


}