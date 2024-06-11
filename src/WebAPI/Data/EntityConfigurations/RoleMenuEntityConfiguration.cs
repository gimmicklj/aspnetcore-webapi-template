using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Data.EntityConfigurations;

internal sealed class RoleMenuEntityConfiguration : IEntityTypeConfiguration<RoleMenu>
{
    public void Configure(EntityTypeBuilder<RoleMenu> builder)
    {
        builder.Property(i => i.Id)
            .HasComment("主键Id")
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(i => i.Id)
            .ValueGeneratedOnAdd()
            .HasComment("主键Id");

        builder.Property(i => i.Rid)
            .HasComment("角色Id");

        builder.Property(i => i.Mid)
            .HasComment("菜单Id");
        
        builder
            .HasOne(pt => pt.SysRole)
            .WithMany(p => p.RoleMenus)
            .HasForeignKey(pt => pt.Rid)
            .OnDelete(DeleteBehavior.Cascade);
 
        builder
            .HasOne(pt => pt.SysMenu)
            .WithMany(p => p.RoleMenus)
            .HasForeignKey(pt => pt.Mid)
            .OnDelete(DeleteBehavior.Cascade);
    }
}