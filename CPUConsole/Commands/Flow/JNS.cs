using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JNS: CommandFormatC
    {
        public JNS(int constant) : base(constant, 27)
        {
        }

        public override void Execute(Registers registers)
        {
            if (!registers.Flags[FlagsRegister.Sign])
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
