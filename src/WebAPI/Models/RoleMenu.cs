namespace WebAPI.Models;

public sealed class RoleMenu
{
    public Guid Id { get; set; }
    
    public Guid? Rid { get; set; }
    
    public Guid Mid { get; set; }
    
    public SysMenu? SysMenu { get; set; }
    
    public SysRole? SysRole { get; set; }
}