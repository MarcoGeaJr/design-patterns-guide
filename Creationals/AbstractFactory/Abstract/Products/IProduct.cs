namespace AbstractFactory.Abstract.Products;

public interface IProduct
{
    string GetName();
    decimal GetPrice(decimal discount);
}