using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// Create a circle of a specific color.
    /// Allow changing the dimensions.
    /// </summary>
    public class DimensionalCircle : Circle
    {
        private ColorTypes mColor;

        public DimensionalCircle(ColorTypes color)
        {
            mColor = color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine($"Draw dimensional circle: color={mColor} X={X} Y={Y} Radius={Radius}.");
        }
    }
}
