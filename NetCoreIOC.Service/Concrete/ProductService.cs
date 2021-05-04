using NetCoreIOC.DataAccess.Interfaces;
using NetCoreIOC.Entities.Models;
using NetCoreIOC.Service.Interfaces;
using System.Collections.Generic;

namespace NetCoreIOC.Service.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll() => _productRepository.GetAll();
    }
}