﻿using System;
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
                Console.WriteLine(" 3- Search for a product ");
                Console.WriteLine(" 4- Edit product ");
                Console.WriteLine(" 5- Delete product ");
                Console.WriteLine(" 6- Exit ");

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
                else if (selectedOpperation == "3")
                {
                    Console.Write("Product name : ");
                    var prodcutName = Console.ReadLine();
                    var prodcut = inventory.SearchForProduct(prodcutName);
                    if (prodcut != null)
                    {
                        prodcut.Log();
                    }
                    else
                    {
                        Console.WriteLine("No product found");
                    }
                }
                else if (selectedOpperation == "4")
                {
                    Console.Write("Product name : ");
                    var prodcutName = Console.ReadLine();
                    Product? product = inventory.SearchForProduct(prodcutName);
                    if (product != null)
                    {
                        Console.Write("Product new name : ");
                        var productNewName = Console.ReadLine();
                        Console.Write("Product new price : ");
                        var productNewPrice = Double.Parse(Console.ReadLine());
                        Console.Write("Product new quantity : ");
                        var productNewQuantitiy = int.Parse(Console.ReadLine());
                        inventory.EditProduct(product, productNewName, productNewPrice, productNewQuantitiy);
                    }
                    else
                    {
                        Console.WriteLine("No product found");
                    }
                }
                else if (selectedOpperation == "5")
                {
                    Console.Write("Product name : ");
                    var prodcutName = Console.ReadLine();
                    inventory.DeleteProduct(prodcutName);
                }
                else if (selectedOpperation == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}