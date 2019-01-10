using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    class Logger
    {
        private static  Logger _instance;
        private readonly StreamWriter _file;

        private Logger()
        {
            var currentDirectory = Directory.GetCurrentDirectory() + @"\logs.txt";
            _file = new StreamWriter(File.OpenWrite(currentDirectory)) {AutoFlush = true};
        }

        public static Logger Instance()
        {
            return _instance ?? (_instance = new Logger());
        }

        public void Log(string message)
        {
            _file.WriteLine(message);
        }
    }
}
