using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Addi : CommandFormatRDSC
    {
        public Addi(int rd, int rs, int constant) : base(rd, rs, constant, 2)
        {
        }

        public override void Execute(Registers registers)
        {
            var answer = registers.Integer[registerSource] + constant;

            registers.Flags[FlagsRegister.Zero] = answer == 0;
            registers.Flags[FlagsRegister.Sign] = answer < 0;
            registers.Flags[FlagsRegister.Overflowing] = Math.Abs(answer) > int.MaxValue;
            registers.Flags[FlagsRegister.Carry] = registers.Flags[FlagsRegister.Overflowing];

            registers.Integer[registerDestination] = answer;
            registers.ProgrammCounter++;
        }
    }
}
