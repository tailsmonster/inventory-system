// Program.cs
using System;

namespace ConsoleInventorySystem;

class Program
{
    static void Main()
    {
        InventoryManager manager = new InventoryManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nInventory System:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Restock Item");
            Console.WriteLine("4. Sell Item");
            Console.WriteLine("5. Remove Item");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Item name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    manager.AddItem(name, price, qty);
                    break;

                case "2":
                    manager.ViewInventory();
                    break;

                case "3":
                    manager.ViewInventory();
                    Console.Write("Index to restock: ");
                    int restockIndex = int.Parse(Console.ReadLine());
                    Console.Write("Amount to add: ");
                    int addQty = int.Parse(Console.ReadLine());
                    manager.RestockItem(restockIndex, addQty);
                    break;

                case "4":
                    manager.ViewInventory();
                    Console.Write("Index to sell: ");
                    int sellIndex = int.Parse(Console.ReadLine());
                    Console.Write("Amount to sell: ");
                    int sellQty = int.Parse(Console.ReadLine());
                    manager.SellItem(sellIndex, sellQty);
                    break;

                case "5":
                    manager.ViewInventory();
                    Console.Write("Index to remove: ");
                    int removeIndex = int.Parse(Console.ReadLine());
                    manager.RemoveItem(removeIndex);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
