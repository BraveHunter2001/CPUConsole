using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Special
{
    internal class SSU : CommandFormatC
    {
       

        public SSU(int constant) : base(constant, 47)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Flags[FlagsRegister.SuperUser] = constant == 1;
        }
    }
}
