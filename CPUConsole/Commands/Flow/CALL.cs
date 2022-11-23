using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class CALL : CommandFormatRDC
    {
        public CALL(int rd, int constant) : base(rd, constant, 0)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.ProgrammCounterCALL = registers.ProgrammCounter;
            registers.ProgrammCounter = constant;
        }
    }
}
