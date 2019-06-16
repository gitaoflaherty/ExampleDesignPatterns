using System;
using DesignPattern;
using DesignPattern.Creational;
using NUnit.Framework;

namespace TestCreational
{
    [TestFixture]
    public class TestPrototype
    {
        /// <summary>
        /// The cache returns a clone!
        /// </summary>
        [Test]
        public void Test1()
        {
            ShapeCache cache = new ShapeCache();
            cache.Load();

            int expectedId = 1;
            IShape clone1 = cache.Get(expectedId);
            clone1.Id = 100;
            clone1 = cache.Get(expectedId);
            Assert.AreEqual(expectedId, clone1.Id);
        }
    }
}
