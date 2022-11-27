using CPUConsole.Commands.ALU.Float;
using CPUConsole.Commands.ALU.Integer;
using CPUConsole.Commands.Flow;
using CPUConsole.Commands.Interrupt;
using CPUConsole.Commands.Memory;
using CPUConsole.Commands.Ports;
using CPUConsole.Commands.Special;
using CPUConsole.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CPUConsole.Commands
{
    public enum CommandOP
    {
        ADD = 1,
        ADDI,
        AND,
        CMP,
        DIV,
        MUL,
        NOT,
        OR,
        RCL,
        RCR,
        SUB,
        XOR,
        ADDF,
        DIVF,
        MULF,
        SUBF,
        TFIX,
        TFLO,
        CALL,
        CLI,
        INT,
        IRET,
        JC,
        JMP,
        JNC,
        JNO,
        JNS,
        JNZ,
        JO,
        JS,
        JZ,
        RET,
        STI,
        LDW,
        LHW,
        LI,
        LW,
        MOV,
        SDW,
        SHW,
        SW,
        SWP,
        IN,
        OUT,
        NON,
        RF,
        SSU,
        WR
       
    }

    
    public  class CommadFactory
    {
        RAM mem = null;
        Port port = null;
       public CommadFactory( RAM mem, Port port)
        {
            this.mem = mem;
            this.port = port;
        }

        public Command CreateCommand(object[] arr)
        {
            Command cmd = null;
            CommandOP op = (CommandOP)arr[0];
            int part1 = arr.Length > 1 ? (int)arr[1] : 0;
            int part2 = arr.Length > 2 ? (int)arr[2] : 0;
            int part3 = arr.Length > 3 ? (int)arr[3] : 0;

            switch (op)
            {
                case CommandOP.ADD:
                    cmd = new Add(part1, part2, part3);
                    break;
                case CommandOP.ADDI:
                    cmd = new Addi(part1, part2, part3);
                    break;
                case CommandOP.AND:
                    cmd = new And(part1, part2, part3);
                    break;
                case CommandOP.CMP:
                    cmd = new Cmp(part1, part2);
                    break;
                case CommandOP.DIV:
                    cmd = new Div(part1, part2, part3);
                    break;
                case CommandOP.MUL:
                    cmd = new Mul(part1, part2, part3);
                    break;
                case CommandOP.NOT:
                    cmd = new Not(part1, part2);
                    break;
                case CommandOP.OR:
                    cmd = new Or(part1, part2, part3);
                    break;
                case CommandOP.RCL:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.RCR:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.SUB:
                    cmd = new Sub(part1, part2, part3);
                    break;
                case CommandOP.XOR:
                    cmd = new Xor(part1, part2, part3);
                    break;
                case CommandOP.ADDF:
                    cmd = new Addf(part1, part2, part3);
                    break;
                case CommandOP.DIVF:
                    cmd = new Divf(part1, part2, part3);
                    break;
                case CommandOP.MULF:
                    cmd = new Milf(part1, part2, part3);
                    break;
                case CommandOP.SUBF:
                    cmd = new Subf(part1, part2, part3);
                    break;
                case CommandOP.TFIX:
                    cmd = new TFIX(part1, part2);
                    break;
                case CommandOP.TFLO:
                    cmd = new TFLO(part1, part2);
                    break;
                case CommandOP.CALL:
                    cmd = new CALL(part1);
                    break;
                case CommandOP.CLI:
                    cmd = new CLI();
                    break;
                case CommandOP.INT:
                    cmd = new INT(part1);
                    break;
                case CommandOP.IRET:
                    cmd = new IRET();
                    break;
                case CommandOP.JC:
                    cmd = new JC(part1);
                    break;
                case CommandOP.JMP:
                    cmd = new Jmp(part1);
                    break;
                case CommandOP.JNC:
                    cmd = new JNC(part1);
                    break;
                case CommandOP.JNO:
                    cmd = new JNO(part1);
                    break;
                case CommandOP.JNS:
                    cmd = new JNS(part1);
                    break;
                case CommandOP.JNZ:
                    cmd = new JNZ(part1);
                    break;
                case CommandOP.JO:
                    cmd = new JO(part1);
                    break;
                case CommandOP.JS:
                    cmd = new JS(part1);
                    break;
                case CommandOP.JZ:
                    cmd = new JZ(part1);
                    break;
                case CommandOP.RET:
                    cmd = new RET();
                    break;
                case CommandOP.STI:
                    cmd = new STI();
                    break;
                case CommandOP.LDW:
                    cmd = new LDW(part1, part2, mem);
                    break;
                case CommandOP.LHW:
                    cmd = new LHW(part1, part2, mem);
                    break;
                case CommandOP.LI:
                    cmd = new LI(part1, part2);
                    break;
                case CommandOP.MOV:
                    cmd = new Mov(part1, part2);
                    break;
                case CommandOP.SDW:
                    cmd = new SDW(part1, part2, mem);
                    break;
                case CommandOP.SHW:
                    cmd = new SDW(part1, part2, mem);
                    break;
                case CommandOP.SW:
                    cmd = new SW(part1, part2, mem);
                    break;
                case CommandOP.SWP:
                    cmd = new SWP(part1, part2);
                    break;
                case CommandOP.IN:
                    cmd = new IN(part1, part2, port);
                    break;
                case CommandOP.OUT:
                    cmd = new OUT(part1, part2, port);
                    break;
                case CommandOP.RF:
                    cmd = new RF(part1);
                    break;
                case CommandOP.SSU:
                    cmd = new SSU(part1);
                    break;
                case CommandOP.WR:
                    cmd = new WR(part1);
                    break;
                case CommandOP.NON:
                    cmd = new Non();
                    break;

            }

            return cmd;
        }
        public  Command CreateCommand(CommandOP op,
            int part1 = 0,
            int part2 = 0,
            int part3 = 0
           )
        {
            Command cmd = null;

            switch (op)
            {
                case CommandOP.ADD:
                    cmd = new Add(part1, part2, part3);
                    break;
                case CommandOP.ADDI:
                    cmd = new Addi(part1, part2, part3);
                    break;
                case CommandOP.AND:
                    cmd = new And(part1, part2, part3);
                    break;
                case CommandOP.CMP:
                    cmd = new Cmp(part1, part2);
                    break;
                case CommandOP.DIV:
                    cmd = new Div(part1, part2, part3);
                    break;
                case CommandOP.MUL:
                    cmd = new Mul(part1, part2, part3);
                    break;
                case CommandOP.NOT:
                    cmd = new Not(part1, part2);
                    break;
                case CommandOP.OR:
                    cmd = new Or(part1, part2, part3);
                    break;
                case CommandOP.RCL:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.RCR:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.SUB:
                    cmd = new Sub(part1, part2, part3);
                    break;
                case CommandOP.XOR:
                    cmd = new Xor(part1, part2, part3);
                    break;
                case CommandOP.ADDF:
                    cmd = new Addf(part1, part2, part3);
                    break;
                case CommandOP.DIVF:
                    cmd = new Divf(part1, part2, part3);
                    break;
                case CommandOP.MULF:
                    cmd = new Milf(part1, part2, part3);
                    break;
                case CommandOP.SUBF:
                    cmd = new Subf(part1, part2, part3);
                    break;
                case CommandOP.TFIX:
                    cmd = new TFIX(part1, part2);
                    break;
                case CommandOP.TFLO:
                    cmd = new TFLO(part1, part2);
                    break;
                case CommandOP.CALL:
                    cmd = new CALL(part1);
                    break;
                case CommandOP.CLI:
                    cmd = new CLI();
                    break;
                case CommandOP.INT:
                    cmd = new INT(part1);
                    break;
                case CommandOP.IRET:
                    cmd = new IRET();
                    break;
                case CommandOP.JC:
                    cmd = new JC(part1);
                    break;
                case CommandOP.JMP:
                    cmd = new Jmp(part1);
                    break;
                case CommandOP.JNC:
                    cmd = new JNC(part1);
                    break;
                case CommandOP.JNO:
                    cmd = new JNO(part1);
                    break;
                case CommandOP.JNS:
                    cmd = new JNS(part1);
                    break;
                case CommandOP.JNZ:
                    cmd = new JNZ(part1);
                    break;
                case CommandOP.JO:
                    cmd = new JO(part1);
                    break;
                case CommandOP.JS:
                    cmd = new JS(part1);
                    break;
                case CommandOP.JZ:
                    cmd = new JZ(part1);
                    break;
                case CommandOP.RET:
                    cmd = new RET();
                    break;
                case CommandOP.STI:
                    cmd = new STI();
                    break;
                case CommandOP.LDW:
                    cmd = new LDW(part1, part2, mem);
                    break;
                case CommandOP.LHW:
                    cmd = new LHW(part1, part2, mem);
                    break;
                case CommandOP.LI:
                    cmd = new LI(part1, part2);
                    break;
                case CommandOP.MOV:
                    cmd = new Mov(part1, part2);
                    break;
                case CommandOP.SDW:
                    cmd = new SDW(part1, part2,mem);
                    break;
                case CommandOP.SHW:
                    cmd = new SDW(part1, part2, mem);
                    break;
                case CommandOP.SW:
                    cmd = new SW(part1, part2, mem);
                    break;
                case CommandOP.SWP:
                    cmd = new SWP(part1, part2);
                    break;
                case CommandOP.IN:
                    cmd = new IN(part1, part2, port);
                    break;
                case CommandOP.OUT:
                    cmd = new OUT(part1, part2, port);
                    break;
                case CommandOP.RF:
                    cmd = new RF(part1);
                    break;
                case CommandOP.SSU:
                    cmd = new SSU(part1);
                    break;
                case CommandOP.WR:
                    cmd = new WR(part1);
                    break;


            }

            return cmd;
        }
    }
}
