using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Cmp : CommandFormatRDS
    {
        public Cmp(int rd, int rs) : base(rd, rs, 7)
        {
        }

        public override void Execute(Registers registers)
        {
            if (registers.Integer[registerDestination] - registers.Integer[registerSource] == 0)
                registers.Flags['Z'] = true;
            registers.ProgrammCounter++;
        }
    }

}
