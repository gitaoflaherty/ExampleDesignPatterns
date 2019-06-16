using System;

namespace DesignPattern.Creational
{
    public class Singleton
    {
        private static Singleton mInstance = new Singleton();
        private static int mCount = 0;

        /// <summary>
        /// Constructor is not public
        /// </summary>
        private Singleton()
        {
        }
  
        /// <summary>
        /// Static method to access static instance
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            mCount++;
            return mInstance;
        }


        public void ShowMessage()
        {
            Console.WriteLine($"Singleton class has been accessed {mCount} times.");
        }
    }
}
