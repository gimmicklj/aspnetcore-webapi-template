using Microsoft.AspNetCore.Identity;

namespace WebAPI.Models;

public sealed class SysUser: IdentityUser<Guid>
{
    public bool IsDeleted { get; set; }
}