﻿using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Float
{
    internal class Addf : CommandFormatRDSS
    {
        public Addf(int rd, int regLeft, int regRight) : base(rd, regLeft, regRight, 15)
        {
        }

        public override void Execute(Registers registers)
        {
            var answer = registers.Float[registerSourceL] + registers.Float[registerSourceR];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = answer > float.MaxValue;
            registers.Flags[FlagsRegister.TransitionHighdigt] = false;

            registers.Float[registerDestination] = answer;
            registers.ProgrammCounter++;
        }
    }
}
