using NetCoreIOC.DataAccess.Interfaces;
using NetCoreIOC.Entities.Models;
using System.Collections.Generic;

namespace NetCoreIOC.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Halley", Price = 5, Stock = 100 },
                new Product { Id = 2, Name = "Marshmallow", Price = 10, Stock = 200 },
                new Product { Id = 3, Name = "Cheetos", Price = 15, Stock = 300 },
                new Product { Id = 4, Name = "Eticin", Price = 20, Stock = 50 },
                new Product { Id = 5, Name = "Albeni", Price = 25, Stock = 60 },
                new Product { Id = 6, Name = "Caramio", Price = 30, Stock = 70 }
            };
        }

        public List<Product> GetAll() => _products;
    }
}