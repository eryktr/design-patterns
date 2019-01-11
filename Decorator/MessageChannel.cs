using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class MessageChannel : IMessageChannel
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
