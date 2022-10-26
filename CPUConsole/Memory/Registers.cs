using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Memory
{
    public class Registers : IDump
    {
        public int[] Integer;
        public float[] Float;

        private int _pc = 0;

        public int ProgrammCounter { get { return _pc; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Programm counter less zero!");
                else 
                    _pc = value;
            } }

        public Dictionary<char,bool> Flags { get; set; }

        public Registers(int[] integer, float[] Float, Dictionary<char,bool> flags)
        {
            Integer = integer;
            this.Float = Float;
            this.Flags = flags;
        }

        public void Dump()
        {
            Console.Write("RegInt[");
            foreach (var i in Integer)
                Console.Write($"{i} ");
            Console.Write("] ");

            Console.Write("RegFloat[");
            foreach (var i in Float)
                Console.Write($"{i} ");
            Console.Write("] ");
            Console.Write($"PC[{_pc}] ");

            Console.Write("Flags: ");
            foreach (var i in Flags)
                Console.Write($"{i.Key}={Convert.ToInt16(i.Value)} ");
            
        }
    }
}
