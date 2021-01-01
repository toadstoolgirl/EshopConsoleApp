using EshopConsoleApp.Services;
using EshopConsoleApp.Models;
using System;
using System.Collections.Generic;


namespace EshopConsoleApp
{



    class Program
    {
        public const string SearchCommand = "/search";
        public const string HelpCommand = "/help";

        static void Main()
        {
            var productService = new ProductServices();
            var products = productService.Create();
            Searching();
            Print(products);
        }
        
        static void Print(List<ProductModel> products)
        {

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}");
                Console.WriteLine($"    {product.Description}");
                Console.WriteLine($"    {product.Cost}");
                Console.WriteLine($"    {product.Category.Name}");
                Console.WriteLine($"    {product.Category.Description}");

                foreach (var teg in product.Teg)
                {
                    Console.WriteLine($"        {teg.Name}");
                    Console.WriteLine($"            {teg.Description}");
                }

            }
        }


        static void Searching()
        {
            while (true)
            {
                Console.WriteLine("Welcome to artists supplies store! \nenter comand,comand manager - /help");
                var comand = Console.ReadLine();
                if (comand != null)
                    switch (comand.ToLower())
                    {
                        case SearchCommand:
                            Search();
                            break;
                        case HelpCommand:
                            Help();
                            break;

                        default:
                            Console.WriteLine("incorrect command");
                            break;
                    }
            }
        }
        
        static void Search()
        {
            Console.WriteLine("enter the name of the request product");
            var searchProduct = Console.ReadLine();
            var productServices = new ProductServices();
            var productAfterSearch = productServices.Search(searchProduct);
            Print(productAfterSearch);
        }

        static void Help()
        {
            Console.WriteLine($"enter /search to get to the search engine module");



        }

    }
}
