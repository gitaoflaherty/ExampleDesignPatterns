using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    /// <summary>
    /// Reduce number of objects created to decrease memory footprint 
    /// and increase performance.
    /// </summary>
    public class FlyweightShapeFactory
    {
        static Dictionary<ColorTypes, IShape> shapesByColor = new Dictionary<ColorTypes, IShape>();

        /// <summary>
        /// Get a circle of the specified color - create if one does not exist.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static IShape GetCircle(ColorTypes color)
        {
            if (!shapesByColor.ContainsKey(color))
            {
                shapesByColor.Add( color, new DimensionalCircle(color));
                Console.WriteLine($"Created {color} circle.");
            }
            return shapesByColor[color];
        }
    }
}
