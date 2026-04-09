using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Element> elements = new List<Element>();

        // Adding first 30 elements
        elements.Add(new Element(1, "Hydrogen", "Non-metal"));
        elements.Add(new Element(2, "Helium", "Noble Gas"));
        elements.Add(new Element(3, "Lithium", "Alkali Metal"));
        elements.Add(new Element(4, "Beryllium", "Alkaline Earth Metal"));
        elements.Add(new Element(5, "Boron", "Metalloid"));
        elements.Add(new Element(6, "Carbon", "Non-metal"));
        elements.Add(new Element(7, "Nitrogen", "Non-metal"));
        elements.Add(new Element(8, "Oxygen", "Non-metal"));
        elements.Add(new Element(9, "Fluorine", "Halogen"));
        elements.Add(new Element(10, "Neon", "Noble Gas"));
        elements.Add(new Element(11, "Sodium", "Alkali Metal"));
        elements.Add(new Element(12, "Magnesium", "Alkaline Earth Metal"));
        elements.Add(new Element(13, "Aluminium", "Metal"));
        elements.Add(new Element(14, "Silicon", "Metalloid"));
        elements.Add(new Element(15, "Phosphorus", "Non-metal"));
        elements.Add(new Element(16, "Sulfur", "Non-metal"));
        elements.Add(new Element(17, "Chlorine", "Halogen"));
        elements.Add(new Element(18, "Argon", "Noble Gas"));
        elements.Add(new Element(19, "Potassium", "Alkali Metal"));
        elements.Add(new Element(20, "Calcium", "Alkaline Earth Metal"));
        elements.Add(new Element(21, "Scandium", "Transition Metal"));
        elements.Add(new Element(22, "Titanium", "Transition Metal"));
        elements.Add(new Element(23, "Vanadium", "Transition Metal"));
        elements.Add(new Element(24, "Chromium", "Transition Metal"));
        elements.Add(new Element(25, "Manganese", "Transition Metal"));
        elements.Add(new Element(26, "Iron", "Transition Metal"));
        elements.Add(new Element(27, "Cobalt", "Transition Metal"));
        elements.Add(new Element(28, "Nickel", "Transition Metal"));
        elements.Add(new Element(29, "Copper", "Transition Metal"));
        elements.Add(new Element(30, "Zinc", "Transition Metal"));

        Console.Write("Enter Atomic Number (1–30): ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Element e in elements)
        {
            if (e.AtomicNumber == num)
            {
                e.ShowElement();
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found.");
        }
    }
}