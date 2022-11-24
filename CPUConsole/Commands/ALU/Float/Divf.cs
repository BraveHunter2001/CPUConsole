using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Float
{
    internal class Divf : CommandFormatRDSS
    {
        public Divf(int rd, int regLeft, int regRight) : base(rd, regLeft, regRight, 14)
        {
        }

        public override void Execute(Registers registers)
        {
            if (registers.Float[registerSourceR] == 0)
                registers.InterruptTable[0]();

            var answer = registers.Float[registerSourceL] / registers.Float[registerSourceR];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = Math.Abs(answer) > float.MaxValue;
            registers.Flags[FlagsRegister.Carry] = registers.Flags[FlagsRegister.Overflowing];

            registers.Float[registerDestination] = answer;
            registers.ProgrammCounter++;
        }
    }
}
