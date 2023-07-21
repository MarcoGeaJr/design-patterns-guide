using AbstractFactory.Abstract.Products;
using System.Diagnostics.CodeAnalysis;

namespace AbstractFactory.Factory.Products;

public class PhysicalProduct : IProduct
{
    [SetsRequiredMembers]
    public PhysicalProduct(string name, decimal price)
    {
        Name = name;
        var addition = price * 10 / 100; // ten percent of original value
        var newPrice = price + addition;
        Price = newPrice;
    }

    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public string GetName()
    {
        return Name;
    }

    /// <summary>
    /// real discount
    /// </summary>
    public decimal GetPrice(decimal discount)
    {
        return Price - discount;
    }
}
