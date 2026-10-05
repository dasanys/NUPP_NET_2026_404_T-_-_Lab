namespace Lab1.Models;

public class CeramicCoating : Service
{
    public int LayersCount { get; set; }
    public int WarrantyMonths { get; set; }

    public CeramicCoating(decimal price, int durationMinutes,
                          int layersCount, int warrantyMonths)
        : base("Керамічне покриття", price, durationMinutes)
    {
        LayersCount = layersCount;
        WarrantyMonths = warrantyMonths;
    }

    public override string GetDescription()
        => $"{Name}: {Price} грн, {DurationMinutes} хв, " +
           $"шарів: {LayersCount}, гарантія: {WarrantyMonths} міс.";
}