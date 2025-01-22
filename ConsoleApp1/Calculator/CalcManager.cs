using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CalcManager
    {
        public CalcLogger ICalcLogger { get; }
        public CalcManager()
        {
            this.ICalcLogger = new CalcLogger();
        }

        public void SumTwoNumbers()
        {
            Calculator calculator = new Calculator(ICalcLogger);
            int a = ReadNumber("a");
            int b = ReadNumber("b");

            int result = calculator.GetCalculated(a, b);
            Console.WriteLine("Результат выполнения сложения: {0}", result);
        }

        public int ReadNumber(string numberName)
        {
            bool isContinue = true;
            int number = 0;
            while (isContinue)
            {
                Console.WriteLine("Введите число {0}: ", numberName);
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    isContinue = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода.");
                }
            }
            return number;
        }
    }
}
