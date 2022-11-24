using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class LI : CommandFormatRDC
    {

        public LI(int reg, int constant) : base(reg, constant, 36)
        {

        }



        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = constant;
            registers.ProgrammCounter++;
        }
    }
}
