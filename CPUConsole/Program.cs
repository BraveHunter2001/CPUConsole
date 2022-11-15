using CPUConsole.Commands;
using CPUConsole.Commands.ALU.Float;
using CPUConsole.Commands.ALU.Integer;
using CPUConsole.Commands.Memory;
using CPUConsole.Memory;

namespace CPUConsole
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Registers registers = new Registers(new int[4], new float[3], new Dictionary<char, bool> {
                {'Z', false }, // Zero 
                {'C', false }, // transition in high digt
                {'S', false }, // sign of result
                {'O', false }, // overflowing
                { 'I', false }, // interrapt
                {'T', false }, // step-by-step mode
                {'U', false } // superuser
            });

            RAM mem = new RAM(10);


            List<Command> commands = new List<Command>()
           {
               new Non(),
               new LI(0,10),
               new LI(1,25),
               new SWP(0,1)
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