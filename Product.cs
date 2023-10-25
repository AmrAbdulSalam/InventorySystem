using System;
using InventoryManagementSystem.LoggableInterface;
using MongoDB.Bson.Serialization.Attributes;
namespace InventoryManagementSystem.ProductInfo
{
    public class Product : ILoggable
    {
        [BsonElement("ProductQuantity")]
        public int ProductQuantity { get; set; }
        [BsonElement("ProductName")]
        public string ProductName { get; set; }
        [BsonElement("ProductPrice")]
        public double? ProductPrice { get; set; }

        public Product()
        {

        }

        public override string ToString() => $"Name = {ProductName}";

        public void Log() => Console.WriteLine($"Name = {ProductName} , Quantity = {ProductQuantity} , Price = {ProductPrice}");
    }
}
