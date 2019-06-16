using DesignPattern;
using DesignPattern.Structural;
using NUnit.Framework;

namespace TestStructural
{
    [TestFixture]
    public class TestDecorator
    {
        [Test]
        public void Test()
        {
            IShape circle = new Circle();
            DecoratorRedShape redCircle = new DecoratorRedShape(new Circle());

            circle.Draw();
            redCircle.Draw();
        }
    }
}
