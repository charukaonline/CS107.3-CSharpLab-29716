using System;

class Product
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    public Product(string productName, decimal price)
    {
        ProductName = productName;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Orange", 14.99m);
        Product product2 = new Product("Apple", 19.99m);

        Console.WriteLine("Product 1: {0}, Price: {1}", product1.ProductName, product1.Price);
        Console.WriteLine("Product 2: {0}, Price: {1}", product2.ProductName, product2.Price);
    }
}
