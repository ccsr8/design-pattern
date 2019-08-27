using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Same instances");
            }
            else
            {
                Console.WriteLine("Different instances");
            }

            Console.Read();
        }
    }
}