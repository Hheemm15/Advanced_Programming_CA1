using System;
using System.Collections.Generic;

public class Menu
{
    public static List<Churros> GetMenu()
    {
        return new List<Churros>
        {
            new Churros("Plain Sugar", 6),
            new Churros("Cinnamon Sugar", 6),
            new Churros("Chocolate Sauce", 8),
            new Churros("Nutella", 8)
        };
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("Delicious Churros:");
        Console.WriteLine("• Churros with plain sugar: €6.00");
        Console.WriteLine("• Churros with cinnamon sugar: €6.00");
        Console.WriteLine("• Churros with chocolate sauce: €8.00");
        Console.WriteLine("• Churros with Nutella: €8.00");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Choose your option:");
        Console.WriteLine("1. Place order");
        Console.WriteLine("2. Deliver order");
        Console.WriteLine("0. Exit");
    }
}