using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    public class DecoratorRedShape : DecoratorShape
    {
        public DecoratorRedShape(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder();
        }

        protected void SetRedBorder()
        {
            Console.WriteLine("DecoratorRedShape Set Border Color: Red");
        }
    }
}
