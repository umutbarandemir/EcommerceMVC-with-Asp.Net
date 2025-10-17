using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceData.Configurations
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(b => b.Description).HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(b => b.Logo).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(b => b.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(b => b.OrderNo).IsRequired().HasDefaultValue(0);
            builder.Property(b => b.CreateDate).IsRequired().HasDefaultValueSql("GETDATE()");

            //builder.HasMany(b => b.Products)
            //       .WithOne(p => p.Brand)
            //       .HasForeignKey(p => p.BrandId)
            //       .OnDelete(DeleteBehavior.Cascade);

            // Seed Data
            builder.HasData(
                new Brand { Id = 1, Name = "TechPro", Description = "High-end electronics brand", Logo = "", IsActive = true, OrderNo = 1, CreateDate = new DateTime(2025, 1, 1) },
                new Brand { Id = 2, Name = "HomeEase", Description = "Home appliances and furniture", Logo = "", IsActive = true, OrderNo = 2, CreateDate = new DateTime(2025, 1, 1) }
            );
        }
    }
}
