using System;

namespace DesignPattern
{
    public class Square : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw square");
        }
    }
}
