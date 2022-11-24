using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Ports
{
    internal class IN : CommandPort
    {
        public IN(int regAddr, int pinPort, Port port) : base(regAddr, pinPort, port, 43)
        {
        }

        public override void Execute(Registers registers)
        {
            port.SendDataToPin(pinPort, registers.Integer[regAddr]);
            registers.ProgrammCounter++;
        }
    }
}
