using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands
{
    public abstract class Command : IDump
    {
        private readonly int _op = 0;
        public int OPcode
        {
            get { return _op; }
        }
        public Command(int opcode)
        {
            _op = opcode;
        }
        public abstract void Execute(Registers registers);
        public abstract void Dump();
    }

    public abstract class CommandFormatRDS : Command
    {
        protected readonly int registerDestination;
        protected readonly int registerSource;
        public CommandFormatRDS(int rd, int rs, int opcode) : base(opcode)
        {
            registerDestination = rd;
            this.registerSource = rs;
        }

        public override void Dump()
        {
            Console.Write($"OP:{OPcode} r{registerDestination} <- r{registerSource}");
        }
    }

    /// <summary>
    /// RegisterFormat dest const opcode
    /// </summary>
    public abstract class CommandFormatRDC : Command
    {
        protected readonly int registerDestination;
        protected readonly int constant;
        public CommandFormatRDC(int rd, int constant, int opcode) : base(opcode)
        {
            registerDestination = rd;
            this.constant = constant;
        }

        public override void Dump()
        {
            Console.Write($"OP:{OPcode} r{registerDestination} <- {constant}");
        }
    }
    /// <summary>
    /// RegisterFormat dest source constant
    /// </summary>
    public abstract class CommandFormatRDSC : CommandFormatRDC
    {
        protected readonly int registerSource;
        public CommandFormatRDSC(int rd,int rs,int constant, int opcode) : base(rd,constant,opcode)
        {
            registerSource = rs;
           
        }

        public override void Dump()
        {
            Console.Write($"OP:{OPcode} r{registerDestination} <- r{registerSource}, {constant}");
        }
    }
    /// <summary>
    /// RegisterFormat dest source constant
    /// </summary>
    public abstract class CommandFormatRDSS : Command
    {
        protected readonly int registerDestination;
        protected readonly int registerSourceL;
        protected readonly int registerSourceR;
        public CommandFormatRDSS(int rd, int regLeft, int regRight, int opcode) : base(opcode)
        {
            registerDestination = rd;
            registerSourceL = regLeft;
            registerSourceR = regRight;
        }

        public override void Dump()
        {
            Console.Write($"OP:{OPcode} r{registerDestination} <- r{registerSourceL}, r{registerSourceR}");
        }
    }
}
