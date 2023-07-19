/*
 * Vamos considerar um cenário em que você está desenvolvendo um sistema de vendas para uma empresa 
 * que possui dois tipos de lojas: Lojas físicas e Lojas online. Cada tipo de loja segue processos diferentes 
 * para realizar vendas, como cálculo de descontos, opções de pagamento e formas de entrega.
 * A empresa deseja que o sistema de vendas seja capaz de lidar com ambas as lojas de forma flexível e extensível. 
 * Aqui é onde você pode aplicar o padrão "Abstract Factory" para resolver esse problema.
 * Situação Problema:
 * Você precisa desenvolver um sistema de vendas que permita criar diferentes tipos de lojas (Lojas físicas e Lojas online) 
 * e que cada tipo de loja tenha sua própria implementação de processos de venda.
 */

using System.Diagnostics.CodeAnalysis;

interface IProduct
{
    string GetName();
    decimal GetPrice(decimal discount);
}

class PhysicalProduct : IProduct
{
    [SetsRequiredMembers]
    public PhysicalProduct(string name, decimal price)
    {
        Name = name;
        var addition = price * 10 / 100; // ten percent of original value
        var newPrice = price + addition;
        Price = newPrice;
    }

    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public string GetName()
    {
        return Name;
    }

    /// <summary>
    /// real discount
    /// </summary>
    public decimal GetPrice(decimal discount)
    {
        return Price - discount;
    }
}

class OnlineProduct : IProduct
{
    [SetsRequiredMembers]
    public OnlineProduct(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public string GetName()
    {
        return Name;
    }

    /// <summary>
    /// percentage discount
    /// </summary>
    public decimal GetPrice(decimal discount)
    {
        return Price - (Price * discount / 100);
    }
}

interface IProductStoreFactory
{
    IProduct CreateProduct(string name, decimal unitPrice);
}

class PhysicalStoreFactory : IProductStoreFactory
{
    public IProduct CreateProduct(string name, decimal unitPrice)
    {
        return new PhysicalProduct(name, unitPrice);
    }
}

class OnlineStoreFactory : IProductStoreFactory
{
    public IProduct CreateProduct(string name, decimal unitPrice)
    {
        return new OnlineProduct(name, unitPrice);
    }
}

interface IStoreAbstractFactory
{
    IProductStoreFactory CreatePhysicalStore();
    IProductStoreFactory CreateOnlineStore();
}

class StoreAbstractFactory : IStoreAbstractFactory
{
    public IProductStoreFactory CreateOnlineStore()
        => new OnlineStoreFactory();

    public IProductStoreFactory CreatePhysicalStore()
        => new PhysicalStoreFactory();
}