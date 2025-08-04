//InventoryManager.cs
using System;
using System.Collections.Generic;

namespace ConsoleInventorySystem;


public class InventoryManager
{
    private List<Item> items = new List<Item>();
    
    public void AddItem(string name, decimal price, int quantity)
    {
        items.Add(new Item(name, price, quantity));
        Console.WriteLine($"Item added: {name}");
    }

    public void ViewInventory()
    {
        Console.WriteLine("\nCurrent Inventory:");
        if (items.Count == 0)
        {
            Console.WriteLine("\nNo items found");
        }

        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"[{i}]  {items[i]}");
        }
    }

    public void RestockItem(int index, int amount)
    {
        if (IsValidIndex(index))
        {
            items[index].Restock(amount);
            Console.WriteLine("Item restocked.");
        }
    }

    public void SellItem(int index, int amount)
    {
        if (IsValidIndex(index))
        {
            if (items[index].Sell(amount))
                Console.WriteLine("Item sold.");
            else
                Console.WriteLine("Not enough stock.");
        }
    }

    public void RemoveItem(int index)
    {
        if (IsValidIndex(index))
        {
            items.RemoveAt(index);
            Console.WriteLine("Item removed.");
        }
    }

    private bool IsValidIndex(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine("Invalid index.");
            return false;
        }
        return true;
    }
}