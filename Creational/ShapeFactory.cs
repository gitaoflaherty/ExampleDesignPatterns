using System;


namespace DesignPattern.Creational
{
    /// <summary>
    /// Why?  Create a specialized object 
    /// (a) using an interface
    /// (b) without requiring the user to know about a specialized class name
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Q: Is this method being an static an issue?
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static IShape Create(ShapeTypes shape)
        {
            switch(shape)
            {
                case ShapeTypes.Circle: return new Circle();
                case ShapeTypes.Square: return new Square();
                case ShapeTypes.Pentagon: return new Pentagon();
                default:
                    throw new NotSupportedException($"Unknown type {shape}");
            }
        }
    }
}
