using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    public class CompositeEmployee
    {
        public string Name
        {
            get;
        }

        public string Department
        {
            get;
        }

        public IList<CompositeEmployee> SubOrdinates
        {
            get;
        } 

        public CompositeEmployee(string name, string dept )
        {
            Name = name;
            Department = dept;
            SubOrdinates = new List<CompositeEmployee>();
        }

        public void AddSubOrdinate( CompositeEmployee subordinate )
        {
            if ( !SubOrdinates.Contains( subordinate ))
            {
                SubOrdinates.Add(subordinate);
            }
        }

        public void RemoveSubOrdinate(CompositeEmployee subordinate)
        {
            if (SubOrdinates.Contains(subordinate))
            {
                SubOrdinates.Remove(subordinate);
            }
        }

        public override string ToString()
        {
            return $"Department={Department} Name={Name}";
        }

    }
}
