using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSafeSingleton
{
    class ConsoleLogger
    {
        private static object _lock = new object();
        private static volatile  ConsoleLogger _instance;
        private volatile int _counter = 0;

        private ConsoleLogger() {}

        public static ConsoleLogger Instance()
        {
            if (_instance != null) return _instance;
            lock (_lock)
            {
                if (_instance != null) return _instance;
                _instance = new ConsoleLogger();
            }

            return _instance;
        }

        public void Log()
        {
            lock (_lock)
            {
                Console.WriteLine($"Value of counter:  {_counter++} from instance {GetHashCode()}");
            }
        }
    }
}