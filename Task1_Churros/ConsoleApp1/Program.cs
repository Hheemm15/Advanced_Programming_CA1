using System;
using System.Collections.Generic;

class Program
{
    static Queue<Order> orders = new Queue<Order>();
    static int orderCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Delicious Churros ---");
            Console.WriteLine("1. Place Order");
            Console.WriteLine("2. Deliver Order");
            Console.WriteLine("0. Exit");

            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                PlaceOrder();
            else if (choice == 2)
                DeliverOrder();
            else if (choice == 0)
                break;
        }
    }

    static void PlaceOrder()
    {
        Console.WriteLine("\n1. Plain Sugar (€6)");
        Console.WriteLine("2. Cinnamon Sugar (€6)");
        Console.WriteLine("3. Chocolate (€8)");
        Console.WriteLine("4. Nutella (€8)");

        Console.Write("Select: ");
        int option = Convert.ToInt32(Console.ReadLine());

        string name = "";
        double price = 0;

        if (option == 1) { name = "Plain Sugar"; price = 6; }
        else if (option == 2) { name = "Cinnamon Sugar"; price = 6; }
        else if (option == 3) { name = "Chocolate"; price = 8; }
        else if (option == 4) { name = "Nutella"; price = 8; }

        Console.Write("Enter Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        Order order = new Order(orderCounter, name, qty, price);
        orders.Enqueue(order);

        order.ShowOrder();
        orderCounter++;
    }

    static void DeliverOrder()
    {
        if (orders.Count == 0)
        {
            Console.WriteLine("No orders.");
            return;
        }

        Order order = orders.Dequeue();
        order.CollectOrder();
    }
}