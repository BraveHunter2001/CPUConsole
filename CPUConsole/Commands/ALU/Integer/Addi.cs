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
        public Addi(int rd, int rs, int constant) : base(rd, rs, constant, 3)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = registers.Integer[registerSource] + constant;
            registers.ProgrammCounter++;
        }
    }
}
