using AbstractFactory.Abstracts.Product;
using AbstractFactory.Models;

namespace AbstractFactory.Concretes.Products;

public class OwnerShipping : IShipping
{
    public OwnerShipping(decimal pricePerKm,
        decimal pricePerCubicCentimeter,
        decimal pricePerKg)
    {
        PricePerKm = pricePerKm;
        PricePerCubicCentimeter = pricePerCubicCentimeter;
        PricePerKg = pricePerKg;
    }

    private decimal PricePerKm { get; set; }
    private decimal PricePerCubicCentimeter { get; set; }
    private decimal PricePerKg { get; set; }

    public decimal GetShippingPrice(ShippingProduct shippingProduct, decimal distance)
    {
        return (distance * PricePerKm)
             + (shippingProduct.Weight * PricePerKg)
             + (shippingProduct.GetCubicSize() * PricePerCubicCentimeter);
    }
}
