﻿using CPUConsole.Memory;
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
            var answer = (int)registers.Float[registerSource];

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = answer > float.MaxValue;
            registers.Flags[FlagsRegister.TransitionHighdigt] = false;

            registers.Integer[registerDestination] = answer;
            registers.ProgrammCounter++;
        }
    }
}
