namespace WebAPI.Abstracts;

public abstract class Entity<TKey> : Entity
{
    public TKey? Id { get; set; }
}
    
public abstract class Entity
{
    public int? Sort { get; set; }
    
    public string? Remark { get; set; }
    
    public string? CreatedBy { get; set; }
    
    public DateTime CreatedTime { get; set; }
    
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedTime { get; set; }
    
    public bool IsDeleted { get; set; }
}