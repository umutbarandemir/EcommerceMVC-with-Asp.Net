using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceData.Configurations
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) // Configure the User entity properties and relationships
        {
            builder.HasKey(u => u.Id); // Set Id as the primary key
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)"); // FirstName is required with a max length of 50
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)"); // LastName is required with a max length of 50
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)"); // Email is required with a max length of 100
            builder.Property(u => u.PhoneNumber).HasMaxLength(15).HasColumnType("varchar(15)"); // PhoneNumber is optional with a max length of 15
            builder.Property(u => u.Password).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)"); // Password is required with a max length of 255
            builder.Property(u => u.IsActive).IsRequired().HasDefaultValue(true); // IsActive is required with a default value of true
            builder.Property(u => u.IsAdmin).IsRequired().HasDefaultValue(false); // IsAdmin is required with a default value of false
            builder.Property(u => u.CreatedAt).IsRequired().HasDefaultValueSql("GETDATE()"); // CreatedAt is required with a default value of the current date
            builder.Property(u => u.UserGuid).IsRequired().HasDefaultValueSql("NEWID()"); // UserGuid is required with a default value of a new GUID
            builder.HasIndex(u => u.Email).IsUnique(); // Ensure Email is unique

            // Seed Data
            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@shop.com",
                    Password = "123456", // (you can hash this later)
                    IsActive = true,
                    IsAdmin = true,
                    CreatedAt = new DateTime(2025, 1, 1),
                    UserGuid = Guid.Parse("11111111-1111-1111-1111-111111111111")
                }
            );
        }
    }
}
