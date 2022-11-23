using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Cmp : CommandFormatRDS
    {
        public Cmp(int rd, int rs) : base(rd, rs, 7)
        {
        }

        public override void Execute(Registers registers)
        {
            var answer = registers.Integer[registerDestination] - registers.Integer[registerSource];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = Math.Abs(answer) > int.MaxValue;
            registers.Flags[FlagsRegister.TransitionHighdigt] = registers.Flags[FlagsRegister.Overflowing];

            registers.ProgrammCounter++;
        }
    }

}
