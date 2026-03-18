using System;

class Order
{
    public int OrderNo { get; set; }
    public string OrderDetails { get; set; }
    public int Quantity { get; set; }
    public double Bill { get; set; }

    public Order(int orderNo, string details, int quantity)
    {
        OrderNo = orderNo;
        OrderDetails = details;
        Quantity = quantity;
    }

    public double PayBill(double price)
    {
        Bill = price * Quantity;
        return Bill;
    }

    public void CollectOrder()
    {
        Console.WriteLine("Delivering Order " + OrderNo + " (" + OrderDetails + ")");
    }
}