using EcommerceCore.Entities;
using EcommerceData.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EcommerceData
{
    internal class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Slide> Slides { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LUCKYLUKE\SQLEXPRESS;Database=EcommerceAspNet;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"); // @ at the start allows for backslashes in the string, This function connects to the database
            /*
             Server=LUCKYLUKE\SQLEXPRESS; → Your local SQL Server instance

            Database=EcommerceAspNet; → The database name EF will create/use

            Trusted_Connection=True; → Uses Windows Authentication (your Windows user credentials)

            TrustServerCertificate=True; → Tells EF to ignore untrusted/self-signed certificates

            MultipleActiveResultSets=true; → Allows multiple queries on one connection (common in EF) 
             */
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserConfig()); // This is the old way of applying configurations

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly); // This applies all configurations in the assembly automatically
            base.OnModelCreating(modelBuilder);
        }

    }
}
