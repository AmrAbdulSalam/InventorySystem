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

        public bool SearchForProduct(string productName)
        {
            foreach (var product in ProductList)
            {
                if(product.ProductName == productName)
                {
                    product.Log();
                    return true;
                }
            }
            Console.WriteLine("Product was not found");
            return false;
        }

        public void EditProduct (string productName)
        {
            foreach (var product in ProductList)
            {
                if (product.ProductName == productName)
                {
                    Console.Write("Product new name : ");
                    product.ProductName = Console.ReadLine();
                    Console.Write("Product new price : ");
                    product.ProductPrice = Double.Parse(Console.ReadLine());
                    Console.Write("Product new quantity : ");
                    product.ProductQuantity = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Product was not found");
        }

        public void DeleteProduct(string productName)
        {
            foreach(var product in ProductList)
            {
                if(product.ProductName == productName)
                {
                    ProductList.Remove(product);
                    Console.WriteLine("Product is deleted");
                    return;
                }
            }
            Console.WriteLine("Product was not found");
        }
    }
}
