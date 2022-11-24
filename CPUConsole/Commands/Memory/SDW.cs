using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class SDW : CommandMemmory
    {
        public SDW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem, 39)
        {
        }

        public override void Execute(Registers registers)
        {
            mem.SetDoubleWord(memmoryAddres, registers.Integer[registerAddres], registers.Integer[registerAddres + 1]);
            registers.ProgrammCounter++;
        }
    }
}
