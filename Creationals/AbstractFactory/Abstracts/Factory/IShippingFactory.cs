using AbstractFactory.Abstracts.Product;

namespace AbstractFactory.Abstracts.Factory
{
    public interface IShippingFactory
    {
        IShipping CreateOwnerShipping();
        IShipping CreateOutsourcedShipping();
    }
}
