/*
 * Vamos considerar um cenário em que você está desenvolvendo um sistema de vendas para uma empresa 
 * que possui dois tipos de produtos: Produtos físicos, vendidos em lojas físicas e Produtos on-line, vendidos em lojas on-line.
 * Cada tipo de produto segue processos diferentes para calcular o seu e o preço de desconto aplicado.
 * A empresa deseja que o sistema de vendas seja capaz de lidar com ambas as lojas de forma flexível e extensível. 
 * Aqui é onde você pode aplicar o padrão "Abstract Factory" para resolver esse problema.
 */

using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Factory;

namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        // concrect instance of abstract factory
        IStoreAbstractFactory abstractFactory = new StoreAbstractFactory();

        // Physical store product factory
        IProductStoreFactory physicalStore = abstractFactory.CreatePhysicalStore();

        // Online store product factory
        IProductStoreFactory onlineStore = abstractFactory.CreateOnlineStore();

        // Instace of physical product
        IProduct pyhsicalProduct = physicalStore.CreateProduct("Physical Keyboard", 99.9M);

        // Instace of online product
        IProduct onlineProduct = onlineStore.CreateProduct("Online Keyboard", 99.9M);

        // The ammount of discount must be applied for the both products
        decimal commonDiscount = 10M;

        Console.WriteLine($"Physical Product Real Price: US$ {pyhsicalProduct.GetPrice(0)}");
        Console.WriteLine($"Physical Product Price: US$ {pyhsicalProduct.GetPrice(commonDiscount)}");
        Console.WriteLine($"Online Product RealPrice: US$ {onlineProduct.GetPrice(0)}");
        Console.WriteLine($"Online Product Price: US$ {onlineProduct.GetPrice(commonDiscount)}");
        Console.ReadLine();
    }
}