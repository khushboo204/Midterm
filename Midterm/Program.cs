public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        int remainingQuantity = QuantityInStock - quantitySold;
        if (remainingQuantity > 0)
        {
            QuantityInStock = remainingQuantity;
        } else
        {
            Console.WriteLine("Current available Item in stock:"+ QuantityInStock + " But you are trying to sell "+ quantitySold);
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if (QuantityInStock > 0)
        {
            return true;
        }

        return false;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine("Printing item details : ");
        Console.WriteLine("Name: " + ItemName);
        Console.WriteLine("ID: " + ItemId);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("QuantityInStock: " + QuantityInStock);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
       
        //Update the price of Laptop
        Console.WriteLine("Old price of Laptop : "+ item1.Price);
        item1.UpdatePrice(2000);
        Console.WriteLine("New price of Laptop : " + item1.Price);

        // 3. Restock an item and print the updated details.
        Console.WriteLine("Old stock of Laptop : " + item1.QuantityInStock);
        item1.RestockItem(5);
        Console.WriteLine("New stock of Laptop : " + item1.QuantityInStock);

        // 2. Sell some items and then print the updated details.
        item1.SellItem(12); // this will pass
        Console.WriteLine("Remaining stock of Laptop after sell: " + item1.QuantityInStock);
        item1.SellItem(5); // this will fail as there are only 3 items in stock

        // 4. Check if an item is in stock and print a message accordingly.
        bool isInStock = item1.IsInStock();
        Console.WriteLine("Current available items in stock : " + isInStock);

        // 1. Print details of all items.
        item1.PrintDetails();

        
        


    }
}
