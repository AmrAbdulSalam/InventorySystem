using System;
using InventoryManagementSystem.ProductInfo;
using InventoryManagementSystem.InventoryInfo;

namespace InventoryManagementSystem.ProgramInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory("Inventory");

            while (true)
            {

                Console.WriteLine("*** Please choose a number ***");
                Console.WriteLine(" 1- Add a new product ");
                Console.WriteLine(" 2- View all products ");

                var selectedOpperation = Console.ReadLine();

                if (selectedOpperation == "1")
                {
                    Console.Write("Product name : ");
                    var prodcutName = Console.ReadLine();
                    Console.Write("Product price : ");
                    var prodcutPrice = Console.ReadLine();
                    Console.Write("Product quantity : ");
                    var prodcutQuantity = Console.ReadLine();

                    var product = new Product()
                    {
                        ProductName = prodcutName,
                        ProductPrice = Double.Parse(prodcutPrice),
                        ProductQuantity = int.Parse(prodcutQuantity)
                    };

                    inventory.AddProduct(product);
                    Console.WriteLine("Product was added successfully");
                }
                else if (selectedOpperation == "2")
                {
                    inventory.ViewProdcuts();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}