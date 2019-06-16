using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    /// <summary>
    /// A wrapper class that provides additional functionality
    /// while keeping the original structure intact.
    /// 
    /// This abstract class is just the wrapper doing the wrapping grunt work
    /// ... subclasses will add the functionality.
    /// </summary>
    public abstract class DecoratorShape : IShape
    {
        private IShape mShape;

        public DecoratorShape(IShape shape)
        {
            mShape = shape;
        }

        public int Id { get => mShape.Id; set => mShape.Id = value; }

        public object Clone()
        {
            return mShape.Clone();
        }

        /// <summary>
        /// Make this virtual to allow subclasses to override.
        /// </summary>
        public virtual void Draw()
        {
            mShape.Draw();
        }
    }
}
