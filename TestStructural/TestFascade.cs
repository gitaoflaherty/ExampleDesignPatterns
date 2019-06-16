using DesignPattern.Structural;
using NUnit.Framework;

namespace TestStructural
{
    [TestFixture]
    class TestFascade
    {
        [Test]
        public void Test()
        {
            FascadeShape shape = new FascadeShape();
            shape.DrawCircle();
            shape.DrawPentagon();
            shape.DrawSquare();
        }
    }
}
