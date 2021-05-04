using Autofac;
using NetCoreIOC.DataAccess.Interfaces;
using NetCoreIOC.DataAccess.Repositories;
using NetCoreIOC.Service.Concrete;
using NetCoreIOC.Service.Interfaces;
using System;

namespace NetCoreIOC.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var _productService = container.Resolve<IProductService>();

            var products = _productService.GetAll();

            foreach (var item in products)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " + item.Name + " Price: " + item.Price + " Stock: " + item.Stock);
            }

            Console.ReadKey();
        }

        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerDependency();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerDependency();
            return builder.Build();
        }
    }
}