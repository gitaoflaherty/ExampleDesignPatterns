

using System;

namespace DesignPattern
{
    public interface IShape : ICloneable
    {
        int Id
        {
            get;
            set;
        }

        void Draw();
    }
}
