using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICartSevice
    {
        List<Product> GetProducts();
        void Add(int productId);
        void Remove(int productId);
    }
}
