using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Ports
{
    internal class USB : Port
    {

        public USB()
        {
            dataPortPins = new int[2];
        }
        public override int ReceiveDataToPin(int dataPin)
        {
           return dataPortPins[dataPin];
        }

        public override void SendDataToPin(int dataPin, int value)
        {
            dataPortPins[dataPin] = value;
        }
    }
}
