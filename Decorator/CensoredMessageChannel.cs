using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class CensoredMessageChannel : MessageChannelDecorator
    {
        private readonly string _censoredWord;

        public CensoredMessageChannel(IMessageChannel channel, string censoredWord) : base(channel)
        {
            _censoredWord = censoredWord;
        }

        public override void Print(string message)
        {
            var newMessage = CensorMessage(message);
            _channel.Print(newMessage);
        }

        private string CensorMessage(string messagge)
        {
            return messagge.Replace(_censoredWord, string.Concat(Enumerable.Repeat("#", _censoredWord.Length)));
        }
    }
}
