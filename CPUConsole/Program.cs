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
            Registers registers = new Registers(new int[4], new float[3]);

            RAM mem = new RAM(10);
            Port port = new USB();


            List<Command> commands = new List<Command>()
           {
               CommadFactory.CreateCommand(CommandOP.Li,0,1),
               CommadFactory.CreateCommand(CommandOP.Li,1,1),
               CommadFactory.CreateCommand(CommandOP.Add,2,1,1)
           };

            for (int i = 0; i < commands.Count; i = registers.ProgrammCounter)
            {
                var curCommand = commands[i];
                curCommand.Dump();
                curCommand.Execute(registers);
                
                
                Console.CursorLeft = 20;
                registers.Dump();
                Console.WriteLine();
                Thread.Sleep(1000);
            }


        }
    }
}