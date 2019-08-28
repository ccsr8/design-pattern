using System;

namespace PrototypePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Base or Original Copy
            var nanoBase = new Nano("Green Nano") { Price = 100000 };
            var fordBase = new Ford("Ford Yellow") { Price = 500000 };
            BasicCar basicCar1;

            // Nano
            basicCar1 = nanoBase.Clone();
            basicCar1.Price = nanoBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", basicCar1.ModelName, basicCar1.Price);

            // Ford
            basicCar1 = fordBase.Clone();
            basicCar1.Price = fordBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", basicCar1.ModelName, basicCar1.Price);

            Console.ReadKey();
        }
    }
}