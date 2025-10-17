using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceData.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150).HasColumnType("varchar(150)");
            builder.Property(p => p.Description).HasColumnType("text");
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Image).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(p => p.ProductCode).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(p => p.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.IsHome).IsRequired().HasDefaultValue(false);
            builder.Property(p => p.OrderNo).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.CreateDate).IsRequired().HasDefaultValueSql("GETDATE()");

            //builder.HasOne(p => p.Brand)
            //       .WithMany(b => b.Products)
            //       .HasForeignKey(p => p.BrandId)
            //       .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(p => p.Category)
            //       .WithMany(c => c.Products)
            //       .HasForeignKey(p => p.CategoryId)
            //       .OnDelete(DeleteBehavior.Cascade);

            // Seed Data
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Smartphone X200",
                    Description = "Latest 5G smartphone",
                    Price = 899.99m,
                    Image = "smartphonex200.png",
                    ProductCode = "SPX200",
                    IsActive = true,
                    Stock = 50,
                    IsHome = true,
                    OrderNo = 1,
                    BrandId = 1,
                    CategoryId = 1,
                    CreateDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    Name = "Air Fryer Pro",
                    Description = "Healthy air fryer for your kitchen",
                    Price = 149.99m,
                    Image = "airfryer.png",
                    ProductCode = "AFP123",
                    IsActive = true,
                    Stock = 30,
                    IsHome = true,
                    OrderNo = 2,
                    BrandId = 2,
                    CategoryId = 2,
                    CreateDate = new DateTime(2025, 1, 1)
                }
            );
        }
    }
}
