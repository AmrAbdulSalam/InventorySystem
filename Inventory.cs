using System;
using InventoryManagementSystem.ProductInfo;

namespace InventoryManagementSystem.InventoryInfo
{
    public class Inventory
    {
        public string InventoryName { get; set; }
        private List<Product> _products = new();

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
            _products.Add(product);
        }

        public void ViewProdcuts()
        {
            foreach (var product in _products)
            {
                product.Log();
            }
        }

        public Product? SearchForProduct(string productName)
        {
            foreach (var product in _products)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }

        public void EditProduct(Product product, string newName, double newPrice, int newQuantity)
        {
            product.ProductName = newName;
            product.ProductPrice = newPrice;
            product.ProductQuantity = newQuantity;
        }

        public void DeleteProduct(string productName)
        {
            Product? product = SearchForProduct(productName);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
