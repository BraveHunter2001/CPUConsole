using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Memory
{
    internal class Memory
    {
        Int32[] mem;
        public Memory(int sizemem)
        {
            mem = new Int32[sizemem];   
        }

        int GetWord(int addr)
        {
            if(addr <= mem.Length)
                return mem[addr];
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addr"></param>
        /// <returns>
        /// (n2, n1) when n2 = mem[addr+1], n1 = mem[addr] 
        /// </returns>
        (int, int) GetDoubleWord(int addr)
        {
            int n1, n2;
            if(addr < mem.Length)
            {
                n1 = mem[addr];
                n2 = mem[addr + 1];
                return (n2, n1);
            }

            return (0, 0);
        }
    }
}
