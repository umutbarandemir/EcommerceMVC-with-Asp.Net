using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(c => c.Description).HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(c => c.Image).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
            builder.Property(c => c.IsTopMenu).IsRequired().HasDefaultValue(false);
            builder.Property(c => c.ParentId).IsRequired().HasDefaultValue(0);
            builder.Property(c => c.OrderNo).IsRequired().HasDefaultValue(0);
            builder.Property(c => c.CreateDate).IsRequired().HasDefaultValueSql("GETDATE()");

            //builder.HasMany(c => c.Products)
            //       .WithOne(p => p.Category)
            //       .HasForeignKey(p => p.CategoryId)
            //       .OnDelete(DeleteBehavior.Cascade);

            // Seed Data
            builder.HasData(
                new Category { Id = 1, Name = "Electronics", Description = "All electronic devices", IsActive = true, IsTopMenu = true, ParentId = 0, OrderNo = 1, CreateDate = new DateTime(2025, 1, 1) },
                new Category { Id = 2, Name = "Home & Kitchen", Description = "Home and kitchen products", IsActive = true, IsTopMenu = true, ParentId = 0, OrderNo = 2, CreateDate = new DateTime(2025, 1, 1) }
            );
        }
    }
}
