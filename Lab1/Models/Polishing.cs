namespace Lab1.Models;

public class Polishing : Service
{
    public string AbrasiveLevel { get; set; }
    public bool WithWaxProtection { get; set; }

    public Polishing(decimal price, int durationMinutes,
                     string abrasiveLevel, bool withWaxProtection)
        : base("Полірування", price, durationMinutes)
    {
        AbrasiveLevel = abrasiveLevel;
        WithWaxProtection = withWaxProtection;
    }

    public override string GetDescription()
        => $"{Name}: {Price} грн, {DurationMinutes} хв, " +
           $"абразив: {AbrasiveLevel}, віск: {(WithWaxProtection ? "так" : "ні")}";
}