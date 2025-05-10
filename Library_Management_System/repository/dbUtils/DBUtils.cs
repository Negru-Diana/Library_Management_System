namespace Library_Management_System.repository.dbUtils;

using System.Data;

public class DBUtils
{
    private static IDbConnection _instance = null;


    public static IDbConnection GetConnection(IDictionary<string,string> props)
    {
        if (_instance == null || _instance.State == ConnectionState.Closed)
        {
            _instance = GetNewConnection(props);
            _instance.Open();
        }
        return _instance;
    }

    private static IDbConnection GetNewConnection(IDictionary<string,string> props)
    {
        return ConnectionFactory.GetInstance().CreateConnection(props);
    }
}