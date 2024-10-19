using DataAccess.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IProductService
    {
        //CRUD Interface
        List<Product> GetAll();
        List<Product> Get(int[] ids);
        List<Category> GetCategories();
        Product? GetById(int id);
        void Create(Product product);
        void Edit(Product product);
        void Delete(int id);
    }
}
