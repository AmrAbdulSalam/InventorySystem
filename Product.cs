using System;
using InventoryManagementSystem.LoggableInterface;

namespace InventoryManagementSystem.ProductInfo
{
    public class Product : ILoggable
    {
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }

        public Product()
        {

        }

        public override string ToString() => $"Name = {ProductName}";

        public void Log() => Console.WriteLine($"Name = {ProductName} , Quantity = {ProductQuantity} , Price = {ProductPrice}");
    }
}
