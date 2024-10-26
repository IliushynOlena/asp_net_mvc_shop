using BusinessLogic.Interfaces;
using DataAccess;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace asp_net_mvc_shop.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepo;
        private readonly IRepository<Category> categorytRepo;

        public ProductService(IRepository<Product> productRepo, 
            IRepository<Category> categorytRepo)
        {
            this.productRepo = productRepo;
            this.categorytRepo = categorytRepo;
        }

        public void Create(Product product)
        {          
            //context.Products.Add(product);
            //context.SaveChanges();
            productRepo.Insert(product);
            productRepo.Save();
        }

        public void Delete(int id)
        {
            //var find = context.Products.Find(id);
            var find = GetById(id);
            if (find == null) return;

            //context.Products.Remove(find);
            //context.SaveChanges();
            productRepo.Delete(find);
            productRepo.Save();
        }

        public void Edit(Product product)
        {
            //context.Products.Update(product);
            //context.SaveChanges();
            productRepo.Update(product);
            productRepo.Save(); 
        }

        public List<Product> Get(int[] ids)
        {
            //return context.Products.Where(p =>ids.Contains(p.Id)).ToList();
            return productRepo.Get(p => ids.Contains(p.Id)).ToList();
        }

        public List<Product> GetAll()
        {
            //return context.Products.ToList();
            return productRepo.Get(includeProperties : new[] { "Category"}).ToList() ;
        }

        public Product? GetById(int id)
        {
            if (id < 0) { return null; }

            //var product = context.Products.Find(id);
            var product =productRepo.GetByID(id) ;

            if (product == null) { return null; }
            return product;
        }

        public List<Category> GetCategories()
        {
            //return context.Categories.ToList();
            return categorytRepo.Get().ToList() ;   
        }
    }
}
