using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Factory.Products;

namespace AbstractFactory.Factory;

public class OnlineStoreFactory : IProductStoreFactory
{
    public IProduct CreateProduct(string name, decimal unitPrice)
    {
        return new OnlineProduct(name, unitPrice);
    }
}