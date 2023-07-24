using System;
using InventoryManagementSystem.LoggableInterface;

namespace InventoryManagementSystem.ProductInfo
{
    public class Product : ILoggable
    {
        public static int ProductId { get; private set; }
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }

        public Product()
        {
            ProductId++;
        }

        public override string ToString() => $"Id {ProductId} : Name = {ProductName}";

        public void Log() => Console.WriteLine($"Id {ProductId} : Name = {ProductName} , Quantity = {ProductQuantity} , Price = {ProductPrice}");
    }
}
