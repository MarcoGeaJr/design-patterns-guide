using AbstractFactory.Abstracts.Product;
using AbstractFactory.Models;

namespace AbstractFactory.Concretes.Products;

public class OutsourceShipping : IShipping
{
    public OutsourceShipping(decimal pricePerKm,
        decimal pricePerCubicCentimeter,
        decimal pricePerKg,
        decimal additionalValue)
    {
        PricePerKm = pricePerKm;
        PricePerCubicCentimeter = pricePerCubicCentimeter;
        PricePerKg = pricePerKg;
        AdditionalValue = additionalValue;
    }

    private decimal PricePerKm { get; set; }
    private decimal PricePerCubicCentimeter { get; set; }
    private decimal PricePerKg { get; set; }
    private decimal AdditionalValue { get; set; }

    public decimal GetShippingPrice(ShippingProduct shippingProduct, decimal distance)
    {
        return (distance * PricePerKm)
             + (shippingProduct.Weight * PricePerKg)
             + (shippingProduct.GetCubicSize() * PricePerCubicCentimeter)
             + AdditionalValue;
    }
}