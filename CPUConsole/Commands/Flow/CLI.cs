using CPUConsole.Memory;

namespace CPUConsole.Commands.Interrupt
{
    internal class CLI : Command
    {
        public CLI() : base(0)
        {
        }


        public override void Execute(Registers registers)
        {

            registers.Flags[FlagsRegister.Iterrapt] = false;

            registers.ProgrammCounter++;
        }
    }
}
