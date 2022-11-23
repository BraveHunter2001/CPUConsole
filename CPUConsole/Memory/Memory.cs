namespace CPUConsole.Memory
{
    public class RAM
    {
        Int32[] mem;
        public RAM(int sizemem)
        {
            mem = new Int32[sizemem];
        }

        public Int16 GetHalfWorld(int addr)
        {
            Int32 word = 0;

            if (addr <= mem.Length)
                word = mem[addr];

            Int16 halfWord = (Int16)word;
            return halfWord;
        }
        public int GetWord(int addr)
        {
            if (addr <= mem.Length)
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
        public (int, int) GetDoubleWordPare(int addr)
        {
            int n1, n2;
            if (addr < mem.Length)
            {
                n1 = mem[addr];
                n2 = mem[addr + 1];
                return (n2, n1);
            }

            return (0, 0);
        }

        public Int64 GetDoubleWord(int addr)
        {
            int n1, n2;
            Int64 w1 = 0, w2 = 0;

            if (addr < mem.Length)
            {
                n1 = mem[addr];
                n2 = mem[addr + 1];

                w2 = ((Int64)n2) << 32;
                w1 = n2;
            }

            return w2 | w1;
        }

        public void SetWord(int addr, int value)
        {
            mem[addr] = value;
        }

        public void SetHalfWorld(int addr, Int16 value)
        {
            if (addr <= mem.Length)
                mem[addr] = value;
        }
        public void SetDoubleWord(int addr, Int64 value)
        {
            int n2 = (int)(value >> 32);
            int n1 = (int)(value);
            Console.WriteLine($"n2: {n2 } n1: {n1}");

            if (addr < mem.Length)
            {
                mem[addr] = n1;
                mem[addr + 1] = n2;
            }

        }

        public void SetDoubleWord(int addr, int val1, int val2)
        {
            int n2 = val2;
            int n1 = val1;
            Console.WriteLine($"n2: {n2} n1: {n1}");

            if (addr < mem.Length)
            {
                mem[addr] = n1;
                mem[addr + 1] = n2;
            }

        }
        public int GetSizeMem() => mem.Length;
    }
}
