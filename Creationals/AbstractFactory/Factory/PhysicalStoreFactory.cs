using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Factory.Products;

namespace AbstractFactory.Factory;

public class PhysicalStoreFactory : IProductStoreFactory
{
    public IProduct CreateProduct(string name, decimal unitPrice)
    {
        return new PhysicalProduct(name, unitPrice);
    }
}
