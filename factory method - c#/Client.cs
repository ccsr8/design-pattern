using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("---");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: Still works.\n" + creator.SomeOperation());
        }
    }
}