using System;

class Churros
{
    public string Type { get; set; }
    public double Price { get; set; }

    public Churros(string type, double price)
    {
        Type = type;
        Price = price;
    }
}