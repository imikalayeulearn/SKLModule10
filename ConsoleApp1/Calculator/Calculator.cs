using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculator
    {
        int GetCalculated(int a, int b);
    }
    internal class Calculator : ICalculator
    {
        ICalcLogger iCalcLogger { get; }

        public Calculator(ICalcLogger iCalcLogger)
        {
            this.iCalcLogger = iCalcLogger;
        }
    
        public int GetCalculated(int a, int b)
        {
            this.iCalcLogger.LogMessage($"Расчет суммы чисел {a} и {b}");
            return a + b;
        }
    }
}
