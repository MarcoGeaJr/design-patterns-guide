namespace AbstractFactory.Abstract;

public interface IStoreAbstractFactory
{
    IProductStoreFactory CreatePhysicalStore();
    IProductStoreFactory CreateOnlineStore();
}