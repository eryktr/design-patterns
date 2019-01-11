using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal abstract class MessageChannelDecorator : IMessageChannel
    {
        protected IMessageChannel _channel;

        protected MessageChannelDecorator(IMessageChannel channel)
        {
            _channel = channel;
        }

        public abstract void Print(string message);
    }
}
