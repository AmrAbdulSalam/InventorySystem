using System;
using InventoryManagementSystem.ProductInfo;
using InventorySystem;

namespace InventoryManagementSystem.InventoryInfo
{
    public class Inventory
    {
        public string InventoryName { get; set; }
        private List<Product> _products = new();
        private Connection _connection = new();
        public Inventory() : this("DefaultInventory")
        {

        }

        public Inventory(string inventoryName)
        {
            InventoryName = inventoryName;
        }

        public override string ToString() => $"Name = {InventoryName}";

        public void AddProduct(Product product)
        {
            var query = $"INSERT INTO Products VALUES ('{product.ProductName}' , {product.ProductPrice} , {product.ProductQuantity})";
            _connection.ExecuteQuery(query);
        }

        public async Task ViewProdcutsAsync()
        {
            var query = "SELECT * FROM Products";
            var output = await _connection.ViewProduct(query);
            Console.WriteLine(output);
        }

        public async Task<String> SearchForProductAsync(string productName)
        {
            var query = $"SELECT * FROM Products where [Product Name] = '{productName}' ";
            var output = await _connection.ViewProduct(query);
            return output;
        }

        public void EditProduct(string product, string newName, double newPrice, int newQuantity)
        {
            var query = $"UPDATE Products " +
                $"SET [Product Name] = '{newName}' , [Product Price] = {newPrice} , [Product Quantity] = {newQuantity}" +
                $"WHERE [Product Name] = '{product}'";
            _connection.ExecuteQuery(query);
        }

        public void DeleteProduct(string productName)
        {
            var query = "DELETE FROM Products " +
                $"WHERE [Product Name] = '{productName}'";
            _connection.ExecuteQuery(query);
        }
    }
}
