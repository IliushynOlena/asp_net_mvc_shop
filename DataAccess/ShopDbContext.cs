using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base() { }
        public ShopDbContext(DbContextOptions options) : base(options) { }
      
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1LCG8OH\SQLEXPRESS;
        //                                    Initial Catalog = Shop_SPR_111;
        //                                    Integrated Security=True;
        //                                    Connect Timeout=30;
        //                                    Encrypt=False;
        //                                    Trust Server Certificate=False;
        //                                    Application Intent=ReadWrite;
        //                                    Multi Subnet Failover=False");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Fluent API 


            //Initialization - Seeder
            modelBuilder.SeedCategories();
            modelBuilder.SeedProducts();
        }


    }
}
