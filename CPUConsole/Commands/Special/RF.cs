using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Special
{
    internal class RF : Command
    {
        int rd;
        public RF(int rd) : base(46)
        {
            this.rd = rd;
        }

        public override void Execute(Registers registers)
        {
            var flags = registers.Flags.Select(o => o.Value);
            int i = 1;
            int sum = 0;
            foreach(var flag in flags)
            {
                sum += (flag  ? 1 : 0) * i;
                i *= 2;
            }
            registers.Integer[rd] = sum;
        }
    }
}
