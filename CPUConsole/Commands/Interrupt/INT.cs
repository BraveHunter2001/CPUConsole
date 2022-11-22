﻿using CPUConsole.Memory;

namespace CPUConsole.Commands.Interrupt
{
    internal class INT : Command
    {
        int codeInterruption = 0;
        public INT(int codeInterruption) : base(0)
        {
            this.codeInterruption = codeInterruption;
        }

        public override void Execute(Registers registers)
        {
            registers.InterruptTable[codeInterruption]();
        }
    }
}
