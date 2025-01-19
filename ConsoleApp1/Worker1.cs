using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IWorker
    {
        void Work();
    }
    internal class Worker1 : IWorker
    {
        ILogger Logger { get; }

        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker1 начал работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 1 закончил работу");
        }
    }
    internal class Worker2 : IWorker
    {
        ILogger Logger { get; }

        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker2 начал работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 2 закончил работу");
        }
    }
    internal class Worker3 : IWorker
    {
        ILogger Logger { get; }

        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker3 начал работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 3 закончил работу");
        }
    }
}
