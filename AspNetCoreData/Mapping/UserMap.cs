using AspNetCoreDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreData.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity> 
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(50);           
        }
    }
}
