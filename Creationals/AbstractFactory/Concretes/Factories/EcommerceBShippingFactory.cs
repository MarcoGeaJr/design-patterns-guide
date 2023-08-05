using AbstractFactory.Abstracts.Factory;
using AbstractFactory.Abstracts.Product;
using AbstractFactory.Concretes.Products;

namespace AbstractFactory.Concretes.Factories;

public class EcommerceBShippingFactory : IShippingFactory
{
    public IShipping CreateOutsourcedShipping()
    {
        return new OutsourceShipping(0.15m, 0.3m, 2.2m, 9.5m);
    }

    public IShipping CreateOwnerShipping()
    {
        return new OwnerShipping(0.15m, 0.3m, 2.2m);
    }
}
