using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands
{
    internal class Jmp : CommandFormatRDS
    {
        public Jmp(int rd, int rs) : base(rd, rs, 3)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = registers.ProgrammCounter;
            registers.ProgrammCounter = registers.Integer[registerSource];
        }
    }
}
