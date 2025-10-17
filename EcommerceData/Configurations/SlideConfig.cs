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
    public class SlideConfig : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(s => s.Description).HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(s => s.Image).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(s => s.Url).HasMaxLength(255).HasColumnType("varchar(255)");

            // Seed Data
            builder.HasData(
                new Slide { Id = 1, Title = "Big Sale", Description = "Up to 50% off on all electronics", Image = "slide1.png", Url = "" },
                new Slide { Id = 2, Title = "New Arrivals", Description = "Check out our latest products!", Image = "slide2.png", Url = "" }
            );
        }
    }
}
