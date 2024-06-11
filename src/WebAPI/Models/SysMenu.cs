using WebAPI.Abstracts;
using WebAPI.Common.Enums;

namespace WebAPI.Models;

public  class SysMenu : Entity<Guid>
{
    public string? Name { get; set; }
    
    public long? ParentId { get; set; }
    
    public string? Code { get; set; }
    
    public string? Icon { get; set; }
    
    public string? Path { get; set; }
    
    public string? Component { get; set; }

    public MenuType Type { get; set; }
    
    public Status Status { get; set; }
    
    public List<RoleMenu>? RoleMenus { get; set; }
}