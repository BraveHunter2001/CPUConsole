using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class And : CommandFormatRDSS
    {
        public And(int rd, int regLeft, int regRight) : base(rd, regLeft, regRight, 8)
        {
        }

        public override void Execute(Registers registers)
        {
            var answer = registers.Integer[registerSourceL] & registers.Integer[registerSourceR];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = answer > int.MaxValue;
            registers.Flags[FlagsRegister.TransitionHighdigt] = false;

            registers.Integer[registerDestination] = answer;
            registers.ProgrammCounter++;
        }
    }
}
