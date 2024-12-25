using Microsoft.EntityFrameworkCore;
using Shop.Models.Entities;

namespace Shop.Models.Infrustructure
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SJNEDPF\\SQLEXPRESS;Database=CW-Shop-MVC;User Id=sa;Password=Nimak1640;TrustServerCertificate=True;"
                );

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(c => c.Description)
                      .HasMaxLength(200);

                // Seed Data for Categories
                entity.HasData(
                    new Category { Id = 1, Name = "Electronics", Description = "محصولات الکترونیکی" },
                    new Category { Id = 2, Name = "Clothing", Description = "پوشاک" },
                    new Category { Id = 3, Name = "Books", Description = "کتاب‌ها" }
                );
            });

            //Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(p => p.Price)
                      .IsRequired()
                      .HasColumnType("decimal(18,2)");

                entity.Property(p => p.Description)
                      .HasMaxLength(500);

                entity.HasOne(p => p.Category)
                      .WithMany(c => c.Products)
                      .HasForeignKey(p => p.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(p => p.User)
                     .WithMany(c => c.Products)
                     .HasForeignKey(p => p.UserId)
                     .OnDelete(DeleteBehavior.Cascade);
                // Seed Data for products
                entity.HasData(
                    new Product { Id = 1, Name = "Laptop", Price = 1500.00m, Description = "لپ‌تاپ حرفه‌ای", CategoryId = 1, UserId = 1 },
                    new Product { Id = 2, Name = "Smartphone", Price = 800.00m, Description = "گوشی هوشمند", CategoryId = 1, UserId = 1 },
                    new Product { Id = 3, Name = "T-Shirt", Price = 20.00m, Description = "تی‌شرت نخی ساده", CategoryId = 2, UserId = 1 },
                    new Product { Id = 4, Name = "Jeans", Price = 50.00m, Description = "شلوار جین", CategoryId = 2, UserId = 1 },
                    new Product { Id = 5, Name = "Programming Book", Price = 30.00m, Description = "کتاب برنامه‌نویسی", CategoryId = 3, UserId = 1 }
                );

            });
            //User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(u => u.Password)
                    .IsRequired()
                    .HasMaxLength(100);
                // Seed Data for User
                entity.HasData(
                    new User
                    {
                        Id = 1,
                        UserName = "Admin",
                        Email = "admin@gmail.com",
                        Password = "password",

                    });
            });
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
