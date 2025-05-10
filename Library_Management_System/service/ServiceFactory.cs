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

    public static ObservableService GetObservableService()
    {
        if (observableService == null)
        {
            IDictionary<string, string> props = new Dictionary<string, string>();
            props.Add("ConnectionString", GetConnectionStringByName("library")); // Folosește funcția pentru obținerea connection string-ului

            IRepositoryBook bookRepo = new BooksDBRepository(props);
            IRepositoryPersonForm personFormRepo = new PersonFormDBRepository(props);
            IRepositoryBorrow borrowRepo = new BorrowDBRepository(props, bookRepo, personFormRepo);
            
            service = new Service(bookRepo, personFormRepo, borrowRepo);
            observableService = new ObservableService(service);

        }
        
        return observableService;
    }
    
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
