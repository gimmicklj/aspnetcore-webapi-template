using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Models;

namespace WebAPI.Data.EntityConfigurations
{
    internal sealed class SysRoleEntityConfiguration : IEntityTypeConfiguration<SysRole>
    {
        public void Configure(EntityTypeBuilder<SysRole> builder)
        {
            builder.Property(i => i.IsDeleted)
                .HasComment("是否删除");
        }
    }
}