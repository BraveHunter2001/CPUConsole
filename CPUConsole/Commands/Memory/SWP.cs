using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class SWP : CommandFormatRDS
    {
        public SWP(int rd, int rs) : base(rd, rs, 42)
        {
        }

        public override void Execute(Registers registers)
        {
            int t = registers.Integer[registerDestination];
            registers.Integer[registerDestination] = registers.Integer[registerSource];
            registers.Integer[registerSource] = t;
            registers.ProgrammCounter++;
        }
    }
}
