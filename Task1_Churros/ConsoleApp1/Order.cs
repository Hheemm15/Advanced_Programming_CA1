using System;

public class Order
{
    private static int counter = 1000; // unique ID generator

    public int OrderNo { get; private set; }
    public string OrderDetails { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Order(string details, int quantity, double price)
    {
        OrderNo = ++counter; // unique order number
        OrderDetails = details;
        Quantity = quantity;
        Price = price;
    }

    public double PayBill()
    {
        return Quantity * Price;
    }

    public void CollectOrder()
    {
        Console.WriteLine("\nOrder Delivered!");
        Console.WriteLine("Order Number: " + OrderNo);
        Console.WriteLine("Item: " + OrderDetails);
        Console.WriteLine("Quantity: " + Quantity);
    }
}