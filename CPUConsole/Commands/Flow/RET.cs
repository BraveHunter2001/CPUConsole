using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class RET : CommandFormatRDC
    {
        public RET(int rd, int constant) : base(rd, constant, 0)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.ProgrammCounter = registers.ProgrammCounterCALL;
        }
    }
}
