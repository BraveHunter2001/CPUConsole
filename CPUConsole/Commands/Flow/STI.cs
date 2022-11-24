using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Interrupt
{
    internal class STI : Command
    {
        public STI() : base(33)
        {
        }

        
        public override void Execute(Registers registers)
        {
            registers.Flags[FlagsRegister.Iterrapt] = true;
            registers.ProgrammCounter++;
        }
    }
}
