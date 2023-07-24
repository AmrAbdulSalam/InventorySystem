using System;
using InventoryManagementSystem.ProductInfo;

namespace InventoryManagementSystem.InventoryInfo
{
    public class Inventory
    {
        private readonly int _Id;
        public static int InventoryIdCounter { get; private set; }
        public string InventoryName { get; set; }
        private List<Product> ProductList;

        public Inventory() : this("DefaultInventory")
        {

        }

        public Inventory(string inventoryName)
        {
            InventoryName = inventoryName;
            ProductList = new List<Product>();
            _Id = InventoryIdCounter++;
        }

        public override string ToString() => $"Id {_Id} : Name = {InventoryName}";

        public void AddProduct(Product product) => ProductList.Add(product);

        public void ViewProdcuts()
        {
            foreach(var product in ProductList)
            {
                product.Log();
            }
        }
    }
}
