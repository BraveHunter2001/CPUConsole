using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.ALU.Integer
{
    internal class Rcl : CommandFormatRDSS
    {
        public Rcl(int rd, int left, int right) : base(rd, left,right,  12)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerDestination] = registers.Integer[registerSourceL] << registers.Integer[registerSourceR] ;
            registers.ProgrammCounter++;
        }
    }
}
