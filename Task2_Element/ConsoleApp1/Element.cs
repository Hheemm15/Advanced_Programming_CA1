using System;

class Element
{
    public int AtomicNumber { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }

    public Element(int atomicNumber, string name, string category)
    {
        AtomicNumber = atomicNumber;
        Name = name;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine("Atomic Number: " + AtomicNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Class: " + Category);
    }
}