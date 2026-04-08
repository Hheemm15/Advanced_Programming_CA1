using System;
using System.Collections.Generic;

class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();
    static List<Churros> menu = Menu.GetMenu();

    static void Main()
    {
        OrderTests.RunTest();

        while (true)
        {
            Menu.ShowMenu();

            Console.Write("Enter choice: ");
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    PlaceOrder();
                    break;

                case 2:
                    DeliverOrder();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void PlaceOrder()
    {
        Console.WriteLine("\nSelect Churros:");

        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i].Name} (€{menu[i].Price})");
        }

        Console.Write("Enter option: ");
        int.TryParse(Console.ReadLine(), out int option);

        if (option < 1 || option > menu.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Churros selected = menu[option - 1];

        Console.Write("Enter quantity: ");
        int.TryParse(Console.ReadLine(), out int qty);

        Order order = new Order(selected.Name, qty, selected.Price);

        double bill = order.PayBill();

        orderQueue.Enqueue(order);

        Console.WriteLine("\nOrder placed successfully!");
        Console.WriteLine("Order Number: " + order.OrderNo);
        Console.WriteLine("Total Bill: €" + bill);
    }

    static void DeliverOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("No orders in queue.");
            return;
        }

        Order order = orderQueue.Dequeue();
        order.CollectOrder();
    }
}