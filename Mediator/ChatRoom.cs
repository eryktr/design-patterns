using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ChatRoom
    {
        public delegate void NewMessage(Message message);
        public event NewMessage OnNewMessage;
        
        public IList<User> Users { get;  }
        public IList<Message> Messages { get; }

        public ChatRoom()
        {
            Users = new List<User>();
            Messages = new List<Message>();
        }

        public void ReceiveMessage(Message message)
        {
            Messages.Add(message);
            OnNewMessage?.Invoke(message);
        }

    }
}
