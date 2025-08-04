//Item.cs


namespace ConsoleInventorySystem;

public class Item
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    
    public Item(string name, decimal price = 0, int quantity = 0)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public void Restock(int amount)
    {
        Quantity += amount;
        Console.WriteLine($"{Name} has been restocked. Quantity: {Quantity}");
    }
    
    public void ChangePrice(decimal newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"{Name}'s price updated to ${Price:F2}");
    }
    
    public bool Sell(int amount)
    {
        if (amount <= Quantity)
        {
            this.Quantity -= amount;
            Console.WriteLine($"Sold {amount} {Name}s. {Quantity} left.");
            return true;
        }
        else
        {
            Console.WriteLine($"Not enough {Name}s in stock. Only {Quantity} left.");
            return false;
        }
    }
    
    public override string ToString()
    {
        return $"{Name} | ${Price:F2} | Stock: {Quantity}";
    }
}