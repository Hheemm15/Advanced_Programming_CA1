using System;

class Order
{
    public int OrderNo;
    public string ItemName;
    public int Quantity;
    private double price;

    // Constructor
    public Order(int orderNo, string itemName, int quantity, double price)
    {
        Console.WriteLine("Order Created");
        OrderNo = orderNo;
        ItemName = itemName;
        Quantity = quantity;
        this.price = price;
    }

    public double PayBill()
    {
        return Quantity * price;
    }

    public void CollectOrder()
    {
        Console.WriteLine("Order Delivered: " + OrderNo);
    }

    public void ShowOrder()
    {
        Console.WriteLine("\nOrder No: " + OrderNo);
        Console.WriteLine("Item: " + ItemName);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total Bill: €" + PayBill());
    }
}