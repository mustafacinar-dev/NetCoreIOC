using NetCoreIOC.DataAccess.Repositories;
using NetCoreIOC.Entities.Models;
using System.Collections.Generic;

namespace NetCoreIOC.Service.Concrete
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetProducts() => _productRepository.GetProducts();
    }
}