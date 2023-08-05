using AbstractFactory.Abstracts.Factory;
using AbstractFactory.Abstracts.Product;
using AbstractFactory.Concretes.Products;

namespace AbstractFactory.Concretes.Factories;

public class EcommerceAShippingFactory : IShippingFactory
{
    public IShipping CreateOutsourcedShipping()
    {
        return new OutsourceShipping(0.1m, 0.2m, 2.5m, 10);
    }

    public IShipping CreateOwnerShipping()
    {
        return new OwnerShipping(0.1m, 0.2m, 2.5m);
    }
}
