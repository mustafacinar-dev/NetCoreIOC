using NetCoreIOC.DataAccess;
using NetCoreIOC.DataAccess.Interfaces;
using NetCoreIOC.DataAccess.Repositories;
using NetCoreIOC.Entities.Models;
using System.Collections.Generic;

namespace NetCoreIOC.Service.Concrete
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = GenericFactory<ProductRepository, IProductRepository>.GetFactory();
        }

        public List<Product> GetProducts() => _productRepository.GetAll();
    }
}