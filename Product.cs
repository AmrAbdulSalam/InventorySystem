using System;
using InventoryManagementSystem.LoggableInterface;

namespace InventoryManagementSystem.ProductInfo
{
    public class Product : ILoggable
    {
        private readonly int _id;
        public static int ProductIdCounter { get; private set; }
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }

        public Product()
        {
            _id = ProductIdCounter++;
        }

        public override string ToString() => $"Id {_id} : Name = {ProductName}";

        public void Log() => Console.WriteLine($"Id {_id} : Name = {ProductName} , Quantity = {ProductQuantity} , Price = {ProductPrice}");
    }
}
