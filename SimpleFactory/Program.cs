using System;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAnimal preferredType = null;
            ISimpleFactory simpleFactory = new SimpleFactory();

            preferredType = simpleFactory.CreateAnimal();
            preferredType.Speak();
            preferredType.Action();

            Console.ReadKey();
        }
    }
}