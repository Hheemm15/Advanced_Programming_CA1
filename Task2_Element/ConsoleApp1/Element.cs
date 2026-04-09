using System;

class Element
{
    public int AtomicNumber;
    public string Name;
    public string Type;

    // Constructor
    public Element(int atomicNumber, string name, string type)
    {
        Console.WriteLine("Element Created");
        AtomicNumber = atomicNumber;
        Name = name;
        Type = type;
    }

    public void ShowElement()
    {
        Console.WriteLine("\nAtomic Number: " + AtomicNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Type: " + Type);
    }
}