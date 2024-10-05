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
                     ImagePath = @"https://static1.squarespace.com/static/5c56a66665019fdb54fb83be/t/637f1fd84aea254bc9a93a25/1669275613716/GOOGLE_PIXEL_7PRO_MAIN.jpg?format=1500w",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "IPhone 14 Pro",
                    Price = 35000,
                     ImagePath = @"https://cdn.new-brz.net/app/public/models/MQ183SX-A/large/w/221108190028339335.webp",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Motorola G8",
                    Price = 5000,
                     ImagePath = @"https://world-smartphones.com.ua/image/data/phones/Motorola/Moto-G8-Power/motorola-moto-g8-power-prev.jpg",
                     CategoryId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Power Bank",
                    Price = 4000,
                     ImagePath = @"https://stark.kiev.ua/wa-data/public/shop/products/24/24/2424/images/1080/1080.970.jpg",
                     CategoryId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Air dots",
                    Price = 999,
                     ImagePath = @"https://belker.com.ua/content/images/14/536x536l50nn0/besprovodnye-naushniki-xiaomi-redmi-airdots-black-zbw4480gl-16031737044081.jpg",
                     CategoryId = 5
                }

           });
        }
    }
}
