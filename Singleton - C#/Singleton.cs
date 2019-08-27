using System;

namespace Singleton
{
    public sealed class Singleton
    {
        #region [Private Members]

        private static readonly Singleton instance = new Singleton();
        private readonly int numberOfInstance = 0;

        #endregion [Private Members]

        #region [Constructor]

        private Singleton()
        {
            numberOfInstance++;
            Console.WriteLine("Number of instance = {0}", numberOfInstance);
        }

        #endregion [Constructor]

        #region [Properties]

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        #endregion [Properties]
    }
}