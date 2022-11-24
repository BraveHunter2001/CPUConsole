using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class Mov : CommandFormatRDS
    {
        public Mov(int rd, int rs) : base(rd, rs, 38)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = registers.Integer[registerSource];
        }
    }
}
