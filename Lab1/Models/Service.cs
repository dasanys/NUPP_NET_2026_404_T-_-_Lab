namespace Lab1.Models;

public abstract class Service
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int DurationMinutes { get; set; }

    protected Service(string name, decimal price, int durationMinutes)
    {
        Name = name;
        Price = price;
        DurationMinutes = durationMinutes;
    }

    public abstract string GetDescription();

    public override string ToString() => GetDescription();
}