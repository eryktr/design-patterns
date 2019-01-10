namespace Iterator.Users
{
    internal class User
    {
        public User(string username)
        {
            Username = username;
            State = UserState.Visible;
        }

        public string Username { get; }
        public UserState State { get; private set; }

        public void SetHidden()
        {
            State = UserState.Hidden;
        }

        public void SetVisible()
        {
            State = UserState.Visible;
        }

        public void JoinChatroom(ChatRoom room)
        {
            room.AcceptUser(this);
        }

        public override string ToString()
        {
            return Username;
        }
    }
}