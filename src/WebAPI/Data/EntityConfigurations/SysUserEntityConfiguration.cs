using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Data.EntityConfigurations;

internal sealed class SysUserEntityTypeConfiguration : IEntityTypeConfiguration<SysUser>
{
    public void Configure(EntityTypeBuilder<SysUser> builder)
    {
        
        builder.Property(i => i.IsDeleted)
            .HasComment("是否删除");
        
    }
}