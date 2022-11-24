using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JNZ : CommandFormatC
    {
        public JNZ(int constant) : base(constant, 28)
        {
        }

        public override void Execute(Registers registers)
        {
            if (!registers.Flags[FlagsRegister.Zero])
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
