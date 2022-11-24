using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class SHW : CommandMemmory
    {
        public SHW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem, 40)
        {
        }

        public override void Execute(Registers registers)
        {
            mem.SetHalfWorld(memmoryAddres, (short)registers.Integer[registerAddres]);
            registers.ProgrammCounter++;
        }
    }
}
