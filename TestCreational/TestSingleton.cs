using DesignPattern.Creational;
using NUnit.Framework;

namespace TestCreational
{
    [TestFixture]
    public class TestSingleton
    {
        /// <summary>
        /// Create a single instance of a type without requiring it to be a static class,
        /// in case you want to extend the functionality.
        /// </summary>
        [Test]
        public void Test()
        {
            // Compile time error - can't instantiate because constructor is private
            //Singleton singleton = new Singleton();

            // Get the only instance of the class
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            // Call an instance method
            singleton.ShowMessage();
        }
    }
}
