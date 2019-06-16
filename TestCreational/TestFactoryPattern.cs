using System;
using DesignPattern;
using DesignPattern.Creational;
using NUnit.Framework;

namespace TestCreational
{
    [TestFixture]
    public class TestFactoryPattern
    {
        /// <summary>
        /// Create a type using the Factory class.
        /// </summary>
        [Test]
        public void Test()
        {
            IShape circle = ShapeFactory.Create(ShapeTypes.Circle);
            circle.Draw();
        }
    }
}
