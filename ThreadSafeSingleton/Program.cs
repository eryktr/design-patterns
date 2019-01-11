using System;
using System.Threading;

namespace ThreadSafeSingleton
{
    internal class Program
    {
        public static void Work()
        {
            Thread.Sleep(10);
            ConsoleLogger.Instance().Log();
        }

        private static void Main(string[] args)
        {
            var start = new ThreadStart(Work);
            for (var i = 0; i < 10; i++) new Thread(start).Start();
            Console.ReadKey();
        }
    }
}