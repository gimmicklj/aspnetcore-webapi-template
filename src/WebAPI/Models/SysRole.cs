using Microsoft.AspNetCore.Identity;

namespace WebAPI.Models;

public sealed class SysRole : IdentityRole<Guid>
{
    public bool IsDeleted { get; set; }
    public List<RoleMenu>? RoleMenus { get; set; }
}