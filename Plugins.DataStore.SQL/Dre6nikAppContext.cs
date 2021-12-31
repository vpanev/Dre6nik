using CoreBusiness;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class Dre6nikAppContext : IdentityDbContext<Customer>
    {
        public Dre6nikAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(e =>
            {
                e.HasKey(x => x.OrderId);
                e.Property(x => x.OrderId).ValueGeneratedOnAdd();
            });


            //customize identity

            modelBuilder.Entity<Customer>(c =>
            {
                c.HasKey(x => x.CustomerId);
                c.Property(x => x.CustomerId).ValueGeneratedOnAdd();

                c.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
                c.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

                c.HasMany(o => o.Orders)
                 .WithOne(x => x.Customer)
                 .HasForeignKey(x => x.CustomerId);

                c.ToTable("AspNetUsers");

                c.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

                c.Property(u => u.UserName).HasMaxLength(256);
                c.Property(u => u.NormalizedUserName).HasMaxLength(256);
                c.Property(u => u.Email).HasMaxLength(256);
                c.Property(u => u.NormalizedEmail).HasMaxLength(256);
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.HasKey(x => x.CategoryId);
                c.Property(x => x.CategoryId).ValueGeneratedOnAdd();

                c.HasMany(c => c.Products)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId);

                c.ToTable("Categories");

                c.Property(x => x.Name).IsRequired().HasMaxLength(256);
                c.Property(x => x.Description).IsRequired().HasMaxLength(256);
                c.Property(x => x.CategoryGender).IsRequired().HasMaxLength(2);
            });

            modelBuilder.Entity<Supplier>(s =>
            {
                s.HasKey(x => x.SupplierId);
                s.Property(x => x.SupplierId).ValueGeneratedOnAdd();

                s.HasMany(s => s.Products)
                    .WithOne(p => p.Supplier)
                    .HasForeignKey(p => p.SupplierId);

                s.ToTable("Suppliers");

                s.Property(x => x.Address).IsRequired().HasMaxLength(100);
                s.Property(x => x.Phone).IsRequired().HasMaxLength(10);
                s.Property(x => x.Email).IsRequired().HasMaxLength(50);
                s.Property(x => x.CompanyName).IsRequired().HasMaxLength(100);
                s.Property(x => x.TypeOfSupplies).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(x => x.ProductId);
                p.Property(x => x.ProductId).ValueGeneratedOnAdd();

                p.HasOne(x => x.Supplier);
            });


            //seeding some data
          /*  modelBuilder.Entity<Category>().HasData(
                new Category { Name = "T-Shirts", Description = "T-Shirts" },
                new Category { Name = "Jackets", Description = "Jackets" },
                new Category { Name = "Jeans", Description = "Jeans" }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    CompanyName = "H&M Shirts",
                    Address = "USA , California",
                    Phone = "0878775584",
                    Email = "usahm@california.com",
                    TypeOfSupplies = "Shirts"
                },
                new Supplier
                {
                    CompanyName = "Leather Jackets",
                    Address = "UK , London",
                    Phone = "0278667322",
                    Email = "leatherjackets@john.com",
                    TypeOfSupplies = "Jackets"
                },
                new Supplier
                {
                    CompanyName = "The Denim",
                    Address = "Spain, Europe",
                    Phone = "0866733233",
                    Email = "info@ddenim.com",
                    TypeOfSupplies = "Denim"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    CategoryId = 1,
                    Name = "Calvin klein t-shirt",
                    Description = "Nice T-shirt",
                    SupplierId = 1,
                    UnitPrice = 34.99,
                    Size = 'M',
                    Color = "Red",
                    UnitsInStock = 5,
                    PictureUrl = "none"
                },
                new Product
                {
                    CategoryId = 2,
                    Name = "Calvin klein Jacket",
                    Description = "Leather Jacket",
                    SupplierId = 2,
                    UnitPrice = 44.99,
                    Size = 'L',
                    Color = "Black",
                    UnitsInStock = 3,
                    PictureUrl = "none"
                },
                new Product
                {
                    CategoryId = 3,
                    Name = "Calvin klein Jeans",
                    Description = "Denim Jeans",
                    SupplierId = 3,
                    UnitPrice = 40.99,
                    Size = 'L',
                    Color = "Black",
                    UnitsInStock = 3,
                    PictureUrl = "none"
                }
            );*/
            base.OnModelCreating(modelBuilder);
        }
    }
}
