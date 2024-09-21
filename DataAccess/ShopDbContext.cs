using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1LCG8OH\SQLEXPRESS;
                                            Initial Catalog = Shop_SPR_111;
                                            Integrated Security=True;
                                            Connect Timeout=30;
                                            Encrypt=False;
                                            Trust Server Certificate=False;
                                            Application Intent=ReadWrite;
                                            Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Initialization - Seeder
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category(){ Id = 1, Name = "Electronics"},
                new Category(){ Id = 2, Name = "Clothes"},
                new Category(){ Id = 3, Name = "Accesories"},
                new Category(){ Id = 4, Name = "Product for children"},
                new Category(){ Id = 5, Name = "Home goods"}
            });
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
