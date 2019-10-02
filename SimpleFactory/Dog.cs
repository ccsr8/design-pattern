using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }
    }
}