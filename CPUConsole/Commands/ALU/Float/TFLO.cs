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
            var answer = registers.Integer[registerSource];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = answer > float.MaxValue;
            registers.Flags[FlagsRegister.TransitionHighdigt] = false;

            registers.Float[registerDestination] = registers.Integer[registerSource];

            registers.ProgrammCounter++;
        }
    }
}
