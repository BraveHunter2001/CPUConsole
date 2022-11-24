using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JC: CommandFormatC
    {
        public JC(int constant) : base(constant, 23)
        {
        }

        public override void Execute(Registers registers)
        {
            if (registers.Flags[FlagsRegister.Carry])
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
