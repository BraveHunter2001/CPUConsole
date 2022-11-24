using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class IRET : Command
    {
        public IRET() : base(22)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.ProgrammCounter = registers.ProgrammCounterInterrupt;
        }
    }
}
