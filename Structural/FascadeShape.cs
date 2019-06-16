using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    /// <summary>
    /// Add a simplified interface for an existing complex interface. 
    /// </summary>
    public class FascadeShape
    {
        private IShape mCircle;
        private IShape mSquare;
        private IShape mPentagon;

        public FascadeShape()
        {
            mCircle = new Circle();
            mSquare = new Square();
            mPentagon = new Pentagon();
        }

        public void DrawCircle()
        {
            mCircle.Draw();
        }

        public void DrawSquare()
        {
            mSquare.Draw();
        }

        public void DrawPentagon()
        {
            mPentagon.Draw();
        }
    }
}
