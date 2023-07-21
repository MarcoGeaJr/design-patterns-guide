using AbstractFactory.Abstract.Products;
using System.Diagnostics.CodeAnalysis;

namespace AbstractFactory.Factory.Products;

public class OnlineProduct : IProduct
{
    [SetsRequiredMembers]
    public OnlineProduct(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public string GetName()
    {
        return Name;
    }

    /// <summary>
    /// percentage discount
    /// </summary>
    public decimal GetPrice(decimal discount)
    {
        return Price - (Price * discount / 100);
    }
}
