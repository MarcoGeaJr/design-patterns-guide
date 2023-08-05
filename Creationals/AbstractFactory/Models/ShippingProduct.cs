namespace AbstractFactory.Models;

public class ShippingProduct
{
    public ShippingProduct(decimal weight,
        decimal width,
        decimal height,
        decimal depth)
    {
        Weight = weight;
        Width = width;
        Height = height;
        Depth = depth;
    }

    public decimal Weight { get; private set; }
    private decimal Width { get; set; }
    private decimal Height { get; set; }
    private decimal Depth { get; set; }

    public decimal GetCubicSize()
        => Width * Height * Depth;
}
