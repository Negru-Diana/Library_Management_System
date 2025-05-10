using System.Configuration;
using Library_Management_System.repository;
using Library_Management_System.repository.DBRepository;

namespace Library_Management_System.service;

public class ServiceFactory
{
    private static ObservableService observableService;
    private static Service service;

    private ServiceFactory()
    {
    }

    
    /// <summary>
    /// Returns a singleton instance of ObservableService.
    /// Initializes repositories and services if they haven't been created yet.
    /// </summary>
    /// <returns>An instance of ObservableService used throughout the application.</returns>
    public static ObservableService GetObservableService()
    {
        if (observableService == null)
        {
            IDictionary<string, string> props = new Dictionary<string, string>();
            props.Add("ConnectionString", GetConnectionStringByName("library"));

            IRepositoryBook bookRepo = new BooksDBRepository(props);
            IRepositoryPersonForm personFormRepo = new PersonFormDBRepository(props);
            IRepositoryBorrow borrowRepo = new BorrowDBRepository(props, bookRepo, personFormRepo);
            
            service = new Service(bookRepo, personFormRepo, borrowRepo);
            observableService = new ObservableService(service);

        }
        
        return observableService;
    }
    
    
    /// <summary>
    /// Retrieves the connection string associated with the given name from the application configuration.
    /// </summary>
    /// <param name="name">The name of the connection string to retrieve.</param>
    /// <returns>The connection string if found; otherwise, null.</returns>
    private static string GetConnectionStringByName(string name)
    {
        string returnValue = null;
        
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

        if (settings != null)
        {
            returnValue = settings.ConnectionString;
        }

        return returnValue;
    }
}
