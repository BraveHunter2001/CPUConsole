using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Ports
{
    internal class OUT : CommandPort
    {
        public OUT(int regAddr, int pinPort, Port port) : base(regAddr, pinPort, port, 44)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[regAddr] = port.ReceiveDataToPin(pinPort);
            registers.ProgrammCounter++;
        }
    }
}
