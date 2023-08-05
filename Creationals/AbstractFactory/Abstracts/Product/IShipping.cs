using AbstractFactory.Models;

namespace AbstractFactory.Abstracts.Product;

public interface IShipping
{
    decimal GetShippingPrice(ShippingProduct shippingProduct, decimal distance);
}
