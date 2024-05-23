using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class InventoryManagement
    {
        public void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Product A", Price = 100, Stock = 5},
                new Product { Name = "Product B", Price = 200, Stock = 3},
                new Product { Name = "Product C", Price = 50, Stock = 10}
            };

            string sortKey = "price";
            bool ascending = false;

            PrintProducts(SortProductList(products, sortKey, ascending));
        }

        public static List<Product> SortProductList(List<Product> products, string sortKey, bool ascending)
        {
            switch (sortKey.ToLower())
            {
                case "name":
                    return ascending ? products.OrderBy(prod => prod.Name).ToList() : products.OrderByDescending(prod => prod.Name).ToList();
                case "price":
                    return ascending ? products.OrderBy(prod => prod.Price).ToList() : products.OrderByDescending(prod => prod.Price).ToList();
                case "stock":
                    return ascending ? products.OrderBy(prod => prod.Stock).ToList() : products.OrderByDescending(prod => prod.Stock).ToList();
                default:
                    throw new Exception("Invalid sort key provided");
            }
        }

        public static void PrintProducts(List<Product> products)
        {
            Console.WriteLine("Sorted products: ");

            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
    }
