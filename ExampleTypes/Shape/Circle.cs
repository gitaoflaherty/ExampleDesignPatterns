using System;

namespace DesignPattern
{
    public class Circle : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
