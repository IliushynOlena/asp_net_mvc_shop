using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    //Seeder
    public static class DbContextExtensions
    {
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
           {
                new Category(){ Id = 1, Name = "Electronics"},
                new Category(){ Id = 2, Name = "Clothes"},
                new Category(){ Id = 3, Name = "Accesories"},
                new Category(){ Id = 4, Name = "Product for children"},
                new Category(){ Id = 5, Name = "Home goods"}
           });
        }
        public static void SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[]
           {
                new Product()
                {
                    Id = 1,
                    Name = "Google Pixel 7 Pro",
                    Price = 7800,
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "IPhone 14 Pro",
                    Price = 35000,
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Motorola G8",
                    Price = 5000,
                     CategoryId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Power Bank",
                    Price = 4000,
                     CategoryId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Air dots",
                    Price = 999,
                     CategoryId = 5
                }

           });
        }
    }
}
