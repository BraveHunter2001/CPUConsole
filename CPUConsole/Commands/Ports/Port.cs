using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Ports
{
    public abstract class Port
    {
        protected int[] dataPortPins;
        public abstract void SendDataToPin(int dataPortPin, int value);
        public abstract int ReceiveDataToPin(int dataPortPin);
        public int GetCountPinsInPort() { return dataPortPins.Length; }

    }
}
