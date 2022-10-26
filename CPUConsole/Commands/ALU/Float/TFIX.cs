using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Float
{
    internal class TFIX : CommandFormatRDS
    {
        public TFIX(int integerRd, int floatRs) : base(integerRd,  floatRs, 20)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = (int)registers.Float[registerSource];
            registers.ProgrammCounter++;
        }
    }
}
