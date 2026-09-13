public delegate void Update();

class Program
{
    public static void UpdateItems()
    {
        Console.WriteLine("Updated the item.");
    }

    public static void UpdateSales()
    {
        Console.WriteLine("Updated the sales.");
    }

    public static void UpdatePurchases()
    {
        Console.WriteLine("Updated the purchases.");
    }

    static void Main()
    {
        // Create an instance of the Update delegate
        Update update = UpdateItems;
        update += UpdateSales;
        update += UpdatePurchases;

        // Invoke the delegate
        update();
    }
}
