using System;
using DesignPattern.Structural;
using NUnit.Framework;

namespace TestStructural
{
    [TestFixture]
    public class TestComposite
    {
        [Test]
        public void Test()
        {
            CompositeEmployee CEO = new CompositeEmployee("John", "CEO");

            CompositeEmployee headSales = new CompositeEmployee("Eve", "Head Sales");
            CompositeEmployee headMarketing = new CompositeEmployee("Tom", "Head Marketing");

            CEO.AddSubOrdinate(headSales);
            CEO.AddSubOrdinate(headMarketing);
            
            CompositeEmployee member1Sales = new CompositeEmployee("Richard", "Sales");
            CompositeEmployee member2Sales = new CompositeEmployee("Rob", "Sales");

            headSales.AddSubOrdinate(member1Sales);
            headSales.AddSubOrdinate(member2Sales);

            CompositeEmployee member1Marketing = new CompositeEmployee("Laura", "Marketing");
            CompositeEmployee member2Marketing = new CompositeEmployee("Bob", "Marketing");

            headMarketing.AddSubOrdinate(member1Marketing);
            headMarketing.AddSubOrdinate(member2Marketing);

            Console.WriteLine(CEO);
            foreach (var subOrdinate in CEO.SubOrdinates)
            {
                Console.WriteLine( "---------" + subOrdinate.ToString() );
                foreach(var subOrdinate2 in subOrdinate.SubOrdinates )
                {
                    Console.WriteLine("------------------" + subOrdinate2.ToString());
                }
            }
        }
    }
}
