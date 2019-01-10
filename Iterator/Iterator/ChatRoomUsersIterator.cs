using System.Collections.Generic;
using Iterator.Users;

namespace Iterator.Iterator
{
    internal class ChatRoomUsersIterator : IIterator<User>
    {
        private int _counter;
        private int _next_index;

        private readonly List<User> _users;

        public ChatRoomUsersIterator(List<User> users)
        {
            _users = users;
            _counter = 0;
            _next_index = 0;
        }

        public bool HasNext()
        {
            for (var i = _counter; i < _users.Count; i++)
            {
                if (_users[i].State != UserState.Visible)
                {
                    _counter++;
                    continue;
                }
                _next_index = i;
                return true;
            }

            return false;
        }

        public User Next()
        {
            if (!HasNext()) return null;
            else
            {
                _counter++;
                return _users[_next_index];
            }
        }
    }
}