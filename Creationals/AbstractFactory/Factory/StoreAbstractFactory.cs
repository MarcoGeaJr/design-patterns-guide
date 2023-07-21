using AbstractFactory.Abstract;

namespace AbstractFactory.Factory;

public class StoreAbstractFactory : IStoreAbstractFactory
{
    public IProductStoreFactory CreateOnlineStore()
        => new OnlineStoreFactory();

    public IProductStoreFactory CreatePhysicalStore()
        => new PhysicalStoreFactory();
}
