using Microsoft.EntityFrameworkCore;

namespace ProductsTestTask.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get;set; }
        public DbSet<Category> Categories { get;set; }
        public DbSet<ProductCategory> ProductCategory { get;set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product(1, "Помидоры"),
                new Product(2, "Огурцы"),
                new Product(3, "Яблоки"),
                new Product(4, "Бананы"),
                new Product(5, "Филе куриное"),
                new Product(6, "Мясо индейки"),
                new Product(7, "Молоко"),
                new Product(8, "Творог")
                );

            modelBuilder.Entity<Category>().HasData(
                new Category(1, "Овощи"),
                new Category(2, "Фрукты"),
                new Category(3, "Мясные продукты"),
                new Category(4, "Молочные продукты")
                );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory(1,1,1),
                new ProductCategory(2,2,1),
                new ProductCategory(3,3,2),
                new ProductCategory(4,4,2),
                new ProductCategory(5,5,3),
                new ProductCategory(6,6,3),
                new ProductCategory(7,7,4),
                new ProductCategory(8,8,4)
                );
        }
        
    }
}
