using AbstractFactory.Abstracts.Factory;

namespace AbstractFactory.Concretes.Factories
{
    public class EcommerceConcreteFactory : IEcommerceAbstractFactory
    {
        public IShippingFactory CreateEcommerceA()
        {
            return new EcommerceAShippingFactory();
        }

        public IShippingFactory CreateEcommerceB()
        {
            return new EcommerceBShippingFactory();
        }
    }
}
