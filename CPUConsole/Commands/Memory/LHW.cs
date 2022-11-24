using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class LHW : CommandMemmory
    {
        public LHW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem, 35)
        {
        }

        
        public override void Execute(Registers registers)
        {
            registers.Integer[registerAddres] = mem.GetHalfWorld(memmoryAddres);
            registers.ProgrammCounter++;
        }
    }
}
