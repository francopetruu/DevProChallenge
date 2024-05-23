using static InventoryManagement;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------INVENTORY MANAGEMENT------");
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
}
