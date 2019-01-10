using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Message
    {
        public string Topic { get; private set; }
        public string Content { get; private set; }

        public Message(string topic, string content)
        {
            Topic = topic;
            Content = content;
        }
    }
}
