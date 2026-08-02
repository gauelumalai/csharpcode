using System;

class Sales
{
    // Encapsulation - Private Fields
    private string productName;
    private double price;
    private int quantity;

    // Properties
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                Console.WriteLine("Invalid Price");
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value > 0)
                quantity = value;
            else
                Console.WriteLine("Invalid Quantity");
        }
    }

    // Constructor
    public Sales(string productName, double price, int quantity)
    {
        this.productName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Calculate Total Sales
    public double CalculateTotal()
    {
        return Price * Quantity;
    }

    // Display Sales Details
    public void DisplaySales()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Sales Details");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Product  : " + ProductName);
        Console.WriteLine("Price    : " + Price);
        Console.WriteLine("Quantity : " + Quantity);
        Console.WriteLine("Total    : " + CalculateTotal());
    }
}

class Program
{
    static void Main()
    {
        // Objects
        Sales s1 = new Sales("Laptop", 50000, 2);
        Sales s2 = new Sales("Mobile", 20000, 3);
        Sales s3 = new Sales("Headphones", 2000, 5);

        // Display sales
        s1.DisplaySales();

        Console.WriteLine();

        s2.DisplaySales();

        Console.WriteLine();

        s3.DisplaySales();

        // Updating quantity using Encapsulation
        Console.WriteLine();

        Console.WriteLine("Old Quantity: " + s1.Quantity);

        s1.Quantity = 3;

        Console.WriteLine("New Quantity: " + s1.Quantity);

        Console.WriteLine("Updated Total: " + s1.CalculateTotal());
    }
}
