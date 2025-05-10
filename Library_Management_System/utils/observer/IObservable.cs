using Library_Management_System.utils.events;

namespace Library_Management_System.utils.observer;

public interface IObservable<TE> where TE : IEvent
{
    void AddObserver(IObserver<TE> observer);
    void RemoveObserver(IObserver<TE> observer);
    void NotifyObservers(TE eventData);
}