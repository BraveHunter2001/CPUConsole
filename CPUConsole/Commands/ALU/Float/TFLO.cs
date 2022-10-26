using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Float
{
    internal class TFLO : CommandFormatRDS
    {
        public TFLO(int floatRd, int integerRs) : base(floatRd, integerRs, 21)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Float[registerDestination] = registers.Integer[registerSource];

            registers.ProgrammCounter++;
        }
    }
}
