using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class LW : CommandMemmory
    {
        public LW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem, 37)
        {
        }

        public override void Execute(Registers registers)
        {
            registers.Integer[registerAddres] = mem.GetWord(memmoryAddres);
            registers.ProgrammCounter++;
        }
    }
}
