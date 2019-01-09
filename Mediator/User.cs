using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class User
    {
        public IList<Message> Messages { get; }
        public string Username { get; }
        private ChatRoom _chatRoom;

        public User(string username)
        {
            Messages = new List<Message>();
            Username = username;
        }

        public void JoinChatRoom(ChatRoom room)
        {
            _chatRoom = room;
            room.Users.Add(this);
            room.OnNewMessage += ReceiveMessage;
        }

        public void SendMessage(string content)
        {
            if (_chatRoom == null) return;
            var message = new Message(this, content);
            _chatRoom.ReceiveMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            Messages.Add(message);
        }
    }

    }