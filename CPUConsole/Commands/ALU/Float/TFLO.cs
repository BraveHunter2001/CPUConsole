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
        public TFLO(int floatRd, int integerRs) : base(floatRd, integerRs, 18)
        {
        }

        public override void Execute(Registers registers)
        {
            var answer = registers.Integer[registerSource];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = Math.Abs(answer) > float.MaxValue;
            registers.Flags[FlagsRegister.Carry] = registers.Flags[FlagsRegister.Overflowing];

            registers.Float[registerDestination] = registers.Integer[registerSource];

            registers.ProgrammCounter++;
        }
    }
}
