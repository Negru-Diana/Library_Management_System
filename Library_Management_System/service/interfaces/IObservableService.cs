using Library_Management_System.domain;
using Library_Management_System.utils.events;

namespace Library_Management_System.service.interfaces;

public interface IObservableService : IService, utils.observer.IObservable<IEvent>
{
    void MoveBooks(IEnumerable<Book> books);
}