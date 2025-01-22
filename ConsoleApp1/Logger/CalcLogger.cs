using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalcLogger
    {
        void LogMessage(string message);
    }
    internal class CalcLogger : ICalcLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
