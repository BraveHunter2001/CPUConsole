using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JO : CommandFormatC
    {
        public JO(int constant) : base( constant, 29)
        {
        }

        public override void Execute(Registers registers)
        {
            if (registers.Flags[FlagsRegister.Overflowing])
            {
               
                registers.ProgrammCounter = constant;
            }
            else
            {
                registers.ProgrammCounter++;
            }
        }
    }
    
    
}
