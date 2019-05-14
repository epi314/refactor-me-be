using System;
using RefactorMe;

namespace ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NZD ===============================================");
            foreach (var product in ProductDataConsolidator.Get())
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Type);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("USD ===============================================");
            foreach (var product in ProductDataConsolidator.GetInUSDollars())
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Type);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("EUR ===============================================");
            foreach (var product in ProductDataConsolidator.GetInEuros())
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Type);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("===============================================");
        }
    }
}
