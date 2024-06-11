using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Data.EntityConfigurations;

internal sealed class SysMenuEntityConfiguration : IEntityTypeConfiguration<SysMenu>
{
    public void Configure(EntityTypeBuilder<SysMenu> builder)
    {
        builder.Property(i => i.Id)
            .HasComment("主键Id")
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(i => i.Sort)
            .HasComment("排序编号");

        builder.Property(i => i.Remark)
            .HasMaxLength(500)
            .HasComment("备注");

        builder.Property(i => i.CreatedBy)
            .HasMaxLength(50)
            .HasComment("创建人");

        builder.Property(i => i.CreatedTime)
            .HasComment("创建时间");

        builder.Property(i => i.ModifiedBy)
            .HasMaxLength(50)
            .HasComment("修改人");

        builder.Property(i => i.ModifiedTime)
            .HasComment("修改时间");

        builder.Property(i => i.IsDeleted)
            .HasComment("是否删除");

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasComment("菜单名称");

        builder.Property(i => i.ParentId)
            .HasComment("父级Id");

        builder.Property(i => i.Code)
            .HasMaxLength(50)
            .HasComment("权限编号");
        
        builder.Property(i => i.Icon)
            .HasMaxLength(100)
            .HasComment("图标");

        builder.Property(i => i.Path)
            .HasMaxLength(100)
            .HasComment("路由地址");

        builder.Property(i => i.Component)
            .HasMaxLength(255)
            .HasComment("组件路径");

        builder.Property(i => i.Type)
            .HasComment("类型(目录，菜单，按钮)");

        builder.Property(i => i.Status)
            .HasComment("状态");
    }
}