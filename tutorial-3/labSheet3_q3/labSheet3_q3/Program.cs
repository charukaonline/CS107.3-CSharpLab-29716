using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet3_q3
{
    public class Product
    {
        private int productID;
        private string productName;
        private double price;
        private int quantityInStock;

        public Product(int productID, string productName, double price, int quantityInStock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public int ProductID
        {
            get { return productID; }
            private set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be empty.");
                }
                productName = value;
            }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public int QuantityInStock
        {
            get { return quantityInStock; }
            private set { quantityInStock = value; }
        }

        public void AddProduct(int quantity)
        {
            QuantityInStock += quantity;
        }

        public bool BuyProduct(int quantity)
        {
            if (QuantityInStock >= quantity)
            {
                QuantityInStock -= quantity;
                return true;
            }
            return false;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Laptop", 800, 10);
            product1.DisplayProductDetails();

            Console.ReadLine();
        }
    }
}
