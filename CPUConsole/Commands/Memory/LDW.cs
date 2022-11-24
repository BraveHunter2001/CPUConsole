using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class LDW : CommandMemmory
    {
        public LDW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem,34)
        {
        }

        public override void Execute(Registers registers)
        {
            (registers.Integer[registerAddres + 1], registers.Integer[registerAddres]) = mem.GetDoubleWordPare(memmoryAddres);
            registers.ProgrammCounter++;
        }
    }
}
