namespace Library_Management_System.domain;

public class Entity<TId>
{
    public TId Id { get; set; }

    public Entity()
    {
    }
    
    public Entity(TId id)
    {
        this.Id = id;
    }
}