namespace Library_Management_System.utils.events;

public class EntityChangeEvent<T> : IEvent
{
    public ChangeEventType Type { get; }
    public T Data { get; }

    public EntityChangeEvent(ChangeEventType type, T data)
    {
        this.Type = type;
        this.Data = data;
    }
    
}