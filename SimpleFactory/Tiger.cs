using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tigers perfer hunting...");
        }

        public void Speak()
        {
            Console.WriteLine("Tigers says: Halum.");
        }
    }
}