using System;
using InventoryManagementSystem.ProductInfo;

namespace InventoryManagementSystem.InventoryInfo
{
    public class Inventory
    {
        public int InventoryId { get; private set; }
        public string InventoryName { get; set; }
        private List<Product> ProductList;

        public Inventory() : this("DefaultInventory")
        {

        }

        public Inventory(string inventoryName)
        {
            InventoryName = inventoryName;
            ProductList = new List<Product>();
            InventoryId++;
        }

        public override string ToString() => $"Id {InventoryId} : Name = {InventoryName}";

        public void AddProduct(Product product) => ProductList.Add(product);
    }
}
