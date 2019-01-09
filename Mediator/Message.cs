using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Message
    {
        public User From { get; }
        public string Content { get; }

        public Message(User author, string content)
        {
            From = author;
            Content = content;
        }
    }
}
