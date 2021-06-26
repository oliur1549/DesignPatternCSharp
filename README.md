# DesignPatternCSharp
Factory Method
Abstract factory
Prototype Pattern


Factory Method:
using System;

namespace FactoryMethodTest
{
    public class Client : IProduct
    {
        public void Headphone(string name)
        {
            Console.WriteLine("Confirm order for-" + name);
        }

        public void Mobile(string name)
        {
            Console.WriteLine("Confirm order for-" + name);
        }
    }
    public interface IProduct
    {
        void Mobile(string name);
        void Headphone(string name);
    }
    public abstract class Factory
    {
        public abstract IProduct Product(string products);
    }
    public class CreateFactory : Factory
    {
        public override IProduct Product(string products)
        {
            switch (products)
            {
                case "product":
                    return new Client();
                default:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", products));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new CreateFactory();
            IProduct product = factory.Product("product");
            product.Mobile("Realme C21");
            product.Headphone("Remax 101");
        }
    }
}
