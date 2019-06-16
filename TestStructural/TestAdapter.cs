using System;
using DesignPattern;
using DesignPattern.Structural;
using NUnit.Framework;

namespace TestStructural
{
    [TestFixture]
    public class TestAdapter
    {
        [Test]
        public void Test()
        {
            IReceiver modelA = new AdapterModelA( new ReceiverModelA());
            modelA.AcquireIQ();          
        }
    }
}
