using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural
{
    /// <summary>
    /// Adapter one interface to another
    /// </summary>
    public class AdapterModelA : IReceiver
    {
        IReceiverModelA mReceiver;

        public AdapterModelA(IReceiverModelA modelA)
        {
            mReceiver = modelA;
        }

        public void AcquireIQ()
        {
            mReceiver.GetIQ();
        }
    }
}
