
using asp_net_mvc_shop;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CartSevice : ICartService
    {
        private readonly IProductService service;
        private readonly HttpContext? httpContext;

        public CartSevice(IProductService service, IHttpContextAccessor httpContextAccessor)
        {
            this.service = service;
            this.httpContext = httpContextAccessor.HttpContext;
        }
        public void Add(int productId)
        {
            var productIds = httpContext.Session.GetObject<List<int>>("cart");
            if (productIds == null) { productIds = new List<int>(); }
            productIds.Add(productId);
            httpContext.Session.SetObject("cart", productIds);
            
        }

        public List<Product> GetProducts()
        {
            var productIds = httpContext.Session.GetObject<List<int>>("cart");
            List<Product> products = new List<Product>();


            if (productIds != null)
            {
                products = service.Get(productIds.ToArray());
            }
            return products;
        }

        public bool IsInCart(int productId)
        {
            var productIds = httpContext.Session.GetObject<List<int>>("cart");
            if(productIds == null) {    return false; } 
            return productIds.Contains(productId);
        }

        public void Remove(int productId)
        {
            var productIds = httpContext.Session.GetObject<List<int>>("cart");
            if (productIds == null) { productIds = new List<int>(); }
            productIds.Remove(productId);
            httpContext.Session.SetObject("cart", productIds);
        }
    }
}
