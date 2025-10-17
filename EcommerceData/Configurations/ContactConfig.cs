using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceData.Configurations
{
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Firstname).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(c => c.Lastname).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(c => c.Phone).HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(c => c.Message).IsRequired().HasMaxLength(1000).HasColumnType("varchar(1000)");
            builder.Property(c => c.CreateDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.IsRead).HasDefaultValue(false);

            // Seed Data
            builder.HasData(
                new Contact
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Doe",
                    Email = "john@example.com",
                    Phone = "5551234567",
                    Message = "Hello, I need help with my order.",
                    CreateDate = new DateTime(2025, 1, 1),
                    IsRead = false
                }
            );
        }
    }
}
