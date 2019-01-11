using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageChannel channel = new MessageChannel();
            channel.Print("Java is the best programming language in the world!");
            IMessageChannel censored = new CensoredMessageChannel(channel, "Java");
            censored.Print("Java is the best programming language in the world!");
            IMessageChannel trimmedCensored = new CensoredMessageChannel(new TrimmedMessageChannel(censored, 10), "Java");
            trimmedCensored.Print("I like Java and I don't like it at the same time.");
            Console.ReadKey();
        }
    }
}
