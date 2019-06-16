using System;

namespace DesignPattern
{
    public class ReceiverModelA : IReceiverModelA
    {
        public void GetIQ()
        {
            Console.WriteLine("Receiver Model A getting IQ data.");
        }
    }
}
