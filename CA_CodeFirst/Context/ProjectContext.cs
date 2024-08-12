using CA_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace CA_CodeFirst.Context
{
    public class ProjectContext:DbContext
    {
        //Categories
        public DbSet<Category> Categories { get; set; }
        //Products
        public DbSet<Product> Products { get; set; }
        //Suppliers
        public DbSet<Supplier> Suppliers { get; set; }

        //Veritabanı Bağlantı İşlemi (ConnectionString tanımlaması)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=CodeFirstSampleDB;Trusted_Connection=True;TrustServerCertificate=true;";
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating: veritabanı oluşturulması esnasında tablolarda belli başlı özelleştirmeler varsa o özellikleri doğrudan ilgili tablo ve o tablodaki içerisinde ilgili kolonlara iletir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category Properties
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(15);

            //Product Properties
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(40);
            modelBuilder.Entity<Product>().Property(x => x.QuantityPerUnit).HasMaxLength(20);

            //Supplier Properties
            modelBuilder.Entity<Supplier>().Property(x => x.CompanyName).HasMaxLength(40);
            modelBuilder.Entity<Supplier>().Property(x => x.ContactName).HasMaxLength(30);
            modelBuilder.Entity<Supplier>().Property(x => x.ContactTitle).HasMaxLength(30);
            modelBuilder.Entity<Supplier>().Property(x => x.Address).HasMaxLength(60);
            modelBuilder.Entity<Supplier>().Property(x => x.City).HasMaxLength(15);
            modelBuilder.Entity<Supplier>().Property(x => x.Region).HasMaxLength(15);
            modelBuilder.Entity<Supplier>().Property(x => x.PostalCode).HasMaxLength(10);
            modelBuilder.Entity<Supplier>().Property(x => x.Country).HasMaxLength(15);
            modelBuilder.Entity<Supplier>().Property(x => x.Phone).HasMaxLength(24);
            modelBuilder.Entity<Supplier>().Property(x => x.Fax).HasMaxLength(24);


        }
    }
}
