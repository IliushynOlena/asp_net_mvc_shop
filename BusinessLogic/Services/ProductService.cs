using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp_net_mvc_shop.Services
{
    public interface IProductService
    {
        //CRUD Interface
        List<Product> GetAll();
        List<Category> GetCategories();
        Product? GetById(int id);
        void Create(Product product);
        void Edit(Product product);
        void Delete(int id);
    }
    public class ProductService : IProductService
    {
        private readonly ShopDbContext context;
        public ProductService(ShopDbContext context)
        {
            this.context = context;
        }

        public void Create(Product product)
        {          
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var find = context.Products.Find(id);
            if (find == null) return;

            context.Products.Remove(find);
            context.SaveChanges();
        }

        public void Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product? GetById(int id)
        {
            if (id < 0) { return null; }

            var product = context.Products.Find(id);

            if (product == null) { return null; }
            return product;
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}
