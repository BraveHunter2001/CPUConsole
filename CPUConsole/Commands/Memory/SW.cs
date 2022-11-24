using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Memory
{
    internal class SW : CommandMemmory
    {
        public SW(int regAddr, int memAddr, RAM mem) : base(regAddr, memAddr, mem, 41)
        {
        }

        public override void Execute(Registers registers)
        {
            mem.SetWord(memmoryAddres, registers.Integer[registerAddres]);
            registers.ProgrammCounter++;
        }
    }
}
