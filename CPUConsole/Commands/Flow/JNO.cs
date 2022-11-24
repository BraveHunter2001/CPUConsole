using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JNO : CommandFormatC
    {
        public JNO(int constant) : base(constant, 26)
        {
        }

        public override void Execute(Registers registers)
        {
            if (!registers.Flags[FlagsRegister.Overflowing])
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
