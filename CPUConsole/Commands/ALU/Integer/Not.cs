using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Not : CommandFormatRDS
    {
        public Not(int rd, int rs) : base(rd, rs, 11)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = ~registers.Integer[registerSource];
            registers.ProgrammCounter++;
        }
    }
}
