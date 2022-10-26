using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
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
            registers.Integer[registerDestination] = registers.Integer[registerSourceL] & registers.Integer[registerSourceR];
            registers.ProgrammCounter++;
        }
    }
}
