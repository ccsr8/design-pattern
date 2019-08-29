using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Director director = new Director();

            var carBuilder = new Car("Ford");
            var motorCycleBuilder = new MotorCycle("Honda");

            // Making Car
            director.Construct(carBuilder);
            var carProduct = carBuilder.GetVehicle();
            carProduct.Show();

            // Making MotorCycle
            director.Construct(motorCycleBuilder);
            var motorCycleProduct = motorCycleBuilder.GetVehicle();
            motorCycleProduct.Show();

            Console.ReadLine();
        }
    }
}