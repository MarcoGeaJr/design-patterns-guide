namespace AbstractFactory.Abstracts.Factory
{
    public interface IEcommerceAbstractFactory
    {
        IShippingFactory CreateEcommerceA();
        IShippingFactory CreateEcommerceB();
    }
}
