using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Iterator;
using Iterator.Users;

namespace Iterator
{
    class ChatRoom : IAggregate<User>
    {
        private readonly List<User> users;

        public ChatRoom()
        {
            users = new List<User>();
        }

        public void AcceptUser(User user)
        {
            users.Add(user);
        }

        public IIterator<User> GetIterator()
        {
            return new ChatRoomUsersIterator(users);
        }
    }
}
