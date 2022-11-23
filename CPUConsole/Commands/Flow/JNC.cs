using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands.Flow
{
    internal class JNC: CommandFormatRDC
    {
        public JNC (int rd, int constant) : base(rd, constant, 0)
        {
        }

        public override void Execute(Registers registers)
        {
            if (!registers.Flags[FlagsRegister.Carry])
            {
                
                registers.ProgrammCounter = constant;
            }
            else
            {
                registers.ProgrammCounter++;
            }
        }
    }
