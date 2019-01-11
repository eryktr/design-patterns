using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class TrimmedMessageChannel : MessageChannelDecorator
    {
        private readonly int _length;

        public TrimmedMessageChannel(IMessageChannel channel, int length) : base(channel)
        {
            _length = length;
        }

        public override void Print(string message)
        {
            var newMessage = TrimMessage(message);
            _channel.Print(newMessage);
        }

        private string TrimMessage(string message)
        {
            return message.Substring(0, _length);
        }
    }
}
