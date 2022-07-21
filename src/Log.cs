using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLog
{
    public class Log
    {
        private string m_Name;

        public Log(string name)
        {
            m_Name = name;
        }

        public void PrintLogLine(object message, MessageType lineType)
        {
            if (lineType == MessageType.Info)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[" + m_Name + "] " + message);
            }
            else if (lineType == MessageType.Success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[" + m_Name + "] " + message);
            }
            else if (lineType == MessageType.Warning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[" + m_Name + "] " + message);
            }
            else if (lineType == MessageType.Error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[" + m_Name + "] " + message);
            }
            else if (lineType == MessageType.Critical)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[" + m_Name + "] " + message);
            }
        }
    }
}
