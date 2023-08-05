using AbstractFactory.Abstracts.Factory;
using AbstractFactory.Abstracts.Product;
using AbstractFactory.Concretes.Factories;
using AbstractFactory.Models;

namespace AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        // concrect instance of abstract factory
        IEcommerceAbstractFactory ecommerceFactory = new EcommerceConcreteFactory();

        ShippingProduct shippingProduct = new ShippingProduct(weight: 0.568m, width: 25m, height: 10m, depth: 5m);
        decimal distance = 50; // 50km

        #region E-commerce A
        // E-commerce A shipping factory
        IShippingFactory ecommerceA = ecommerceFactory.CreateEcommerceA();

        // Instace of owner shipping of E-commerce A
        IShipping ownerShippingA = ecommerceA.CreateOwnerShipping();

        // Instace of outsourced shipping of E-commerce A
        IShipping outsourcedShippingA = ecommerceA.CreateOutsourcedShipping();

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("E-commerce A Shipping");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Owner Shipping Price: US{ownerShippingA.GetShippingPrice(shippingProduct, distance):C}");
        Console.WriteLine($"Outsourced Shipping Price: US{outsourcedShippingA.GetShippingPrice(shippingProduct, distance):C}");
        Console.WriteLine("--------------------------------------");
        #endregion

        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine();

        #region E-commerce B
        // E-commerce B shipping factory
        IShippingFactory ecommerceB = ecommerceFactory.CreateEcommerceB();

        // Instace of owner shipping of E-commerce B
        IShipping ownerShippingB = ecommerceB.CreateOwnerShipping();

        // Instace of outsourced shipping of E-commerce B
        IShipping outsourcedShippingB = ecommerceB.CreateOutsourcedShipping();

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("E-commerce B Shipping");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Owner Shipping Price: US{ownerShippingB.GetShippingPrice(shippingProduct, distance):C}");
        Console.WriteLine($"Outsourced Shipping Price: US{outsourcedShippingB.GetShippingPrice(shippingProduct, distance):C}");
        Console.WriteLine("--------------------------------------");
        #endregion

        Console.WriteLine();
        Console.ReadLine();
    }
}