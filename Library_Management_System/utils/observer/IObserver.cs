using Library_Management_System.utils.events;

namespace Library_Management_System.utils.observer;

public interface IObserver<TE> where TE : IEvent
{
    void Update(TE eventData);
}