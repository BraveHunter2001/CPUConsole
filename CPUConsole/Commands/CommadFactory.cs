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
        Add = 1,
        Addi,
        And,
        Cmp,
        Div,
        Mul,
        Not,
        Or,
        Rcl,
        Rcr,
        Sub,
        Xor,
        Addf,
        Divf,
        Mulf,
        Subf,
        TFIX,
        TFLO,
        Call,
        Cli,
        Int,
        Iret,
        Jc,
        Jmp,
        Jnc,
        Jno,
        Jns,
        Jnz,
        Jo,
        Js,
        Jz,
        Ret,
        Sti,
        Ldw,
        Lhw,
        Li,
        Lw,
        Mov,
        Sdw,
        Shw,
        Sw,
        Swp,
        In,
        Out,
        Non,
        Rf,
        Ssu,
        Wr
    }

    
    public static class CommadFactory
    {
       
        public static Command CreateCommand(CommandOP op,
            int part1 = 0,
            int part2 = 0,
            int part3 = 0,
            RAM mem = null,
            Port port = null)
        {
            Command cmd = null;

            switch (op)
            {
                case CommandOP.Add:
                    cmd = new Add(part1, part2, part3);
                    break;
                case CommandOP.Addi:
                    cmd = new Addi(part1, part2, part3);
                    break;
                case CommandOP.And:
                    cmd = new And(part1, part2, part3);
                    break;
                case CommandOP.Cmp:
                    cmd = new Cmp(part1, part2);
                    break;
                case CommandOP.Div:
                    cmd = new Div(part1, part2, part3);
                    break;
                case CommandOP.Mul:
                    cmd = new Mul(part1, part2, part3);
                    break;
                case CommandOP.Not:
                    cmd = new Not(part1, part2);
                    break;
                case CommandOP.Or:
                    cmd = new Or(part1, part2, part3);
                    break;
                case CommandOP.Rcl:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.Rcr:
                    cmd = new Rcl(part1, part2, part3);
                    break;
                case CommandOP.Sub:
                    cmd = new Sub(part1, part2, part3);
                    break;
                case CommandOP.Xor:
                    cmd = new Xor(part1, part2, part3);
                    break;
                case CommandOP.Addf:
                    cmd = new Addf(part1, part2, part3);
                    break;
                case CommandOP.Divf:
                    cmd = new Divf(part1, part2, part3);
                    break;
                case CommandOP.Mulf:
                    cmd = new Milf(part1, part2, part3);
                    break;
                case CommandOP.Subf:
                    cmd = new Subf(part1, part2, part3);
                    break;
                case CommandOP.TFIX:
                    cmd = new TFIX(part1, part2);
                    break;
                case CommandOP.TFLO:
                    cmd = new TFLO(part1, part2);
                    break;
                case CommandOP.Call:
                    cmd = new CALL(part1);
                    break;
                case CommandOP.Cli:
                    cmd = new CLI();
                    break;
                case CommandOP.Int:
                    cmd = new INT(part1);
                    break;
                case CommandOP.Iret:
                    cmd = new IRET();
                    break;
                case CommandOP.Jc:
                    cmd = new JC(part1);
                    break;
                case CommandOP.Jmp:
                    cmd = new Jmp(part1);
                    break;
                case CommandOP.Jnc:
                    cmd = new JNC(part1);
                    break;
                case CommandOP.Jno:
                    cmd = new JNO(part1);
                    break;
                case CommandOP.Jns:
                    cmd = new JNS(part1);
                    break;
                case CommandOP.Jnz:
                    cmd = new JNZ(part1);
                    break;
                case CommandOP.Jo:
                    cmd = new JO(part1);
                    break;
                case CommandOP.Js:
                    cmd = new JS(part1);
                    break;
                case CommandOP.Jz:
                    cmd = new JZ(part1);
                    break;
                case CommandOP.Ret:
                    cmd = new RET();
                    break;
                case CommandOP.Sti:
                    cmd = new STI();
                    break;
                case CommandOP.Ldw:
                    cmd = new LDW(part1, part2, mem);
                    break;
                case CommandOP.Lhw:
                    cmd = new LHW(part1, part2, mem);
                    break;
                case CommandOP.Li:
                    cmd = new LI(part1, part2);
                    break;
                case CommandOP.Mov:
                    cmd = new Mov(part1, part2);
                    break;
                case CommandOP.Sdw:
                    cmd = new SDW(part1, part2,mem);
                    break;
                case CommandOP.Shw:
                    cmd = new SDW(part1, part2, mem);
                    break;
                case CommandOP.Sw:
                    cmd = new SW(part1, part2, mem);
                    break;
                case CommandOP.Swp:
                    cmd = new SWP(part1, part2);
                    break;
                case CommandOP.In:
                    cmd = new IN(part1, part2, port);
                    break;
                case CommandOP.Out:
                    cmd = new OUT(part1, part2, port);
                    break;
                case CommandOP.Rf:
                    cmd = new RF(part1);
                    break;
                case CommandOP.Ssu:
                    cmd = new SSU(part1);
                    break;
                case CommandOP.Wr:
                    cmd = new WR(part1);
                    break;


            }

            return cmd;
        }
    }
}
