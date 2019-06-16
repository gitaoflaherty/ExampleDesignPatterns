using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class AbstractShape : IShape
    {
        public int Id { get; set; }

        public object Clone()
        {
            // Shallow copy is okay for this example.
            // Deep copy would be required if this class included custom types.
            return MemberwiseClone();
        }

        public abstract void Draw();
    }
}
