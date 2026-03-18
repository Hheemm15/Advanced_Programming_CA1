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

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    PlaceOrder();
                    break;

                case 2:
                    DeliverOrder();
                    break;

                case 0:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void PlaceOrder()
    {
        Console.WriteLine("\nChoose Churros:");
        Console.WriteLine("1. Plain Sugar (€6)");
        Console.WriteLine("2. Cinnamon Sugar (€6)");
        Console.WriteLine("3. Chocolate Sauce (€8)");
        Console.WriteLine("4. Nutella (€8)");
        Console.Write("Select option: ");

        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        string type = "";
        double price = 0;

        switch (option)
        {
            case 1:
                type = "Plain Sugar";
                price = 6;
                break;

            case 2:
                type = "Cinnamon Sugar";
                price = 6;
                break;

            case 3:
                type = "Chocolate Sauce";
                price = 8;
                break;

            case 4:
                type = "Nutella";
                price = 8;
                break;

            default:
                Console.WriteLine("Invalid churros option.");
                return;
        }

        Console.Write("Enter quantity: ");

        if (!int.TryParse(Console.ReadLine(), out int qty))
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        Order order = new Order(orderCounter, type, qty);
        double bill = order.PayBill(price);

        orders.Enqueue(order);

        Console.WriteLine("Order placed successfully!");
        Console.WriteLine("Order Number: " + orderCounter);
        Console.WriteLine("Total Bill: €" + bill);

        orderCounter++;
    }

    static void DeliverOrder()
    {
        if (orders.Count == 0)
        {
            Console.WriteLine("No orders in queue.");
            return;
        }

        Order order = orders.Dequeue();
        order.CollectOrder();
    }
}