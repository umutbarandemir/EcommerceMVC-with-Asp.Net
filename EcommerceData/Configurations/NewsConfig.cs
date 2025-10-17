using EcommerceCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Configurations
{
    public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<News> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Title).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(n => n.Content).IsRequired().HasMaxLength(1000).HasColumnType("text");
            builder.Property(n => n.Image).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(n => n.CreateDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(n => n.IsActive).HasDefaultValue(false);
            // Seed Data
            builder.HasData(
                new News
                {
                    Id = 1,
                    Title = "Welcome to Our New E-commerce Platform",
                    Content = "We are excited to announce the launch of our new e-commerce platform. Stay tuned for more updates!",
                    Image = "",
                    CreateDate = new DateTime(2025, 1, 1),
                    IsActive = true
                }
            );
        }
    }
}
