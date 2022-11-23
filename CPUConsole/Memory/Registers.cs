namespace CPUConsole.Memory
{
    public enum FlagsRegister
    {
        Zero = 'Z',
        TransitionHighdigt = 'C',
        Sign = 'S',
        Overflowing = 'O',
        Iterrapt = 'I',
        StepByStep = 'T',
        SuperUser = 'U'
    }
    public class Registers : IDump
    {

        public int[] Integer;
        public float[] Float;

        private int _pc = 0;
        private int _pcIterrupt = 0;

        public int ProgrammCounter
        {
            get { return _pc; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Programm counter less zero!");
                else
                    _pc = value;
            }
        }

        public int ProgrammCounterInterrupt
        {
            get { return _pcIterrupt; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Programm counter less zero!");
                else
                    _pcIterrupt = value;
            }
        }

        public Dictionary<FlagsRegister, bool> Flags { get; set; }
        public Dictionary<FlagsRegister, bool> FlagsInterrupt { get; set; }

        public Registers(int[] integer, float[] Float, Dictionary<FlagsRegister, bool> flags)
        {
            Integer = integer;
            this.Float = Float;
            this.Flags = flags;
        }

        public Registers(int[] integer, float[] Float)
        {
            Integer = integer;
            this.Float = Float;
            this.Flags = new Dictionary<FlagsRegister, bool> {
                {FlagsRegister.Zero, false }, // Zero 
                {FlagsRegister.TransitionHighdigt, false }, // transition in high digt
                {FlagsRegister.Sign, false }, // Negative
                {FlagsRegister.Overflowing, false }, // overflowing
                {FlagsRegister.Iterrapt, false }, // interrapt
                {FlagsRegister.StepByStep, false }, // step-by-step mode
                {FlagsRegister.SuperUser, false } // superuser
            }; ;
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

        public Dictionary<int, Action> InterruptTable = new Dictionary<int, Action>()
        {
            {0, Interrupts.DividedZeroException},
            {1,  Interrupts.RegisterException},
            {2, Interrupts.MemoryException}
        };


    }
}
