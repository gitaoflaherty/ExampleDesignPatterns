using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational
{
    /// <summary>
    /// Prototype Pattern
    /// Load from database (expensive operation) and store in cache;
    /// </summary>
    public class ShapeCache
    {
        Dictionary<int, IShape> mCache = new Dictionary<int, IShape>();

        /// <summary>
        /// Load from database
        /// </summary>
        public void Load()
        {
            int id = 1;
            mCache.Add(id, new Circle() { Id = id } );

            id = 2;
            mCache.Add(id, new Square() { Id = id });

            id = 3;
            mCache.Add(id, new Pentagon() { Id = id });
        }

        /// <summary>
        /// Return the clone of the cache
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IShape Get( int id )
        {
            if( mCache.Keys.Contains( id ) )
            {
                return (IShape) mCache[id].Clone();
            }
            return null;
        }
    }
}
