using CPUConsole.Commands;

namespace CPUConsole
{
    public class Parser
    {
        string path = null;

        public Parser(string path)
        {
            this.path = path;
        }

        public List<object[]> GetCommands()
        {
            List<object[]> comObjs = new List<object[]>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string commandLine = sr.ReadLine();
                    string[] commands = commandLine.Split(' ');

                    for (int i = 0; i < commands.Length; i++)
                    {
                        if (commands[i].Contains(","))
                            commands[i] = commands[i].Remove(commands[i].Length - 1);
                    }

                    Object[] args = new Object[commands.Length];
                    args[0] = ParseCommandOP(commands[0]);
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (int.TryParse(commands[i], out int res))
                            args[i] = res;
                        else
                            throw new Exception("Parse exp");
                    }
                    
                    comObjs.Add(args);
                }
            }
            return comObjs;
        }

        private CommandOP ParseCommandOP(string str)
        {
            if (Enum.TryParse(str, out CommandOP result))
            {
                return result;
            }else
                throw new Exception("Error in command parse");
        }
    }
}
