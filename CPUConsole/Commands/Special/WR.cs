using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Special
{
    internal class WR : Command
    {
        int rd = 0;
        public WR(int rd) : base( 48)
        {
            this.rd = rd;
        }

        public override void Execute(Registers registers)
        {
            int ans = registers.Integer[rd];
            Dictionary<FlagsRegister, bool> newFlags = new Dictionary<FlagsRegister, bool>()
            {
                {FlagsRegister.Zero, ans % 2 == 1 },
                {FlagsRegister.Carry, ans % 4 == 1 },
                {FlagsRegister.Sign, ans % 8 == 1 },
                {FlagsRegister.Overflowing, ans % 16 == 1 }, // overflowing
                {FlagsRegister.Iterrapt, ans % 32 == 1 }, // interrapt
                {FlagsRegister.StepByStep, ans % 64 == 1 }, // step-by-step mode
                {FlagsRegister.SuperUser, ans % 128 == 1 }
            };

            registers.Flags = newFlags;
        }
    }
}
