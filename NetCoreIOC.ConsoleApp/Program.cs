using NetCoreIOC.Service.Concrete;
using System;

namespace NetCoreIOC.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            var products = productService.GetProducts();

            foreach (var item in products)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " + item.Name + " Price: " + item.Price + " Stock: " + item.Stock);
            }

            Console.ReadKey();
        }
    }
}