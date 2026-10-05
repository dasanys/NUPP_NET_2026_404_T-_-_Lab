namespace Lab1.Models;

public class CarWash : Service
{
    public bool IsContactless { get; set; }
    public bool WithInteriorCleaning { get; set; }

    public CarWash(decimal price, int durationMinutes,
                   bool isContactless, bool withInteriorCleaning)
        : base("Мийка", price, durationMinutes)
    {
        IsContactless = isContactless;
        WithInteriorCleaning = withInteriorCleaning;
    }

    public override string GetDescription()
        => $"{Name}: {Price} грн, {DurationMinutes} хв, " +
           $"безконтактна: {(IsContactless ? "так" : "ні")}, " +
           $"салон: {(WithInteriorCleaning ? "так" : "ні")}";
}