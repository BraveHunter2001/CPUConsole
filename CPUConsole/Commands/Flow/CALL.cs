using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class CALL : CommandFormatC
    {
        public CALL(int constant) : base(constant, 19)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.ProgrammCounterCALL = registers.ProgrammCounter;
            registers.ProgrammCounter = constant;
        }
    }
}
