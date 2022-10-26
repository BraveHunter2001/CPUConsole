using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands
{
    public class Non : Command
    {
        public Non() : base(0) // opcode = 0
        {}

        public override void Dump()
        {
            Console.Write($"OP:{OPcode}");
        }

        public override void Execute(Registers registers)
        {
            registers.ProgrammCounter++;
        }
    }
}
