using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Add : CommandFormatRDSS
    {

        public Add(int regOut, int regLeft, int regRight) : base(regOut, regLeft, regRight, 2)
        {

        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = registers.Integer[registerSourceL] + registers.Integer[registerSourceR];
            registers.ProgrammCounter++;
        }
    }
}
