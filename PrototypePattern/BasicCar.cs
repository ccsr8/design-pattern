using System;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }

        public int Price { get; set; }

        public static int SetPrice()
        {
            int price = 0;
            var r = new Random();
            var p = r.Next(200000, 500000);
            price = p;

            return price;
        }

        public abstract BasicCar Clone();
    }
}