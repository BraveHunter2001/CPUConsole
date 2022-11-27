using CPUConsole.Commands;
using CPUConsole.Commands.ALU.Float;
using CPUConsole.Commands.ALU.Integer;
using CPUConsole.Commands.Interrupt;
using CPUConsole.Commands.Memory;
using CPUConsole.Commands.Ports;
using CPUConsole.Commands.Special;
using CPUConsole.Memory;

namespace CPUConsole
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser(@"C:\Users\Ilya\Desktop\comm.txt");
            CPU cpu = new CPU();

            var t = p.GetCommands();
            List<Command> commands = new List<Command>();

            foreach (var c in t)
            {
                commands.Add(cpu.commadFactory.CreateCommand(c));
            }
            
           
           

            cpu.AddCommands(commands);

            cpu.ExecuteCommands();
        }
    }
}