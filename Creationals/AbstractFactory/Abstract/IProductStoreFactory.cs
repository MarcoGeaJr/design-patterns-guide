using AbstractFactory.Abstract.Products;

namespace AbstractFactory.Abstract;

public interface IProductStoreFactory
{
    IProduct CreateProduct(string name, decimal unitPrice);
}