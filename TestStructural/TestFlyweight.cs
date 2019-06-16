using System;
using System.Threading;
using DesignPattern;
using DesignPattern.Structural;
using NUnit.Framework;

namespace TestStructural
{
    [TestFixture]
    public class TestFlyweight
    {
        private int GetSeed()
        {
            Thread.Sleep(1);
            int seed = DateTime.Now.Millisecond;
            //Console.WriteLine($"Seed = {seed}");
            return seed;
        }

        private ColorTypes GetRandomColor()
        {
            int max = Enum.GetValues(typeof(ColorTypes)).Length - 1;
            Random rand = new Random(GetSeed());
            return (ColorTypes) rand.Next(max);
        }

        private int GetRandomInteger()
        {
            Random rand = new Random(GetSeed());
            return rand.Next();
        }

        [Test]
        public void Test()
        {
            for (int i = 0; i < 20; i++)
            {
                DimensionalCircle circle = (DimensionalCircle) FlyweightShapeFactory.GetCircle(GetRandomColor());
                circle.X = GetRandomInteger();
                circle.Y = GetRandomInteger();
                circle.Radius = GetRandomInteger();
                circle.Draw();
            }
        }
    }
}
