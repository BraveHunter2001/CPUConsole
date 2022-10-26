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
        public Divf(int rd, int regLeft, int regRight) : base(rd, regLeft, regRight, 19)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Float[registerDestination] = registers.Float[registerSourceL] / registers.Float[registerSourceR];
            registers.ProgrammCounter++;
        }
    }
}
