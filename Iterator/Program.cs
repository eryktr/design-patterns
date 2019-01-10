using System;
using Iterator.Users;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();
            var john = new User("john");
            var tim = new User("tim");
            var ann = new User("ann");
            var jill = new User("jill");
            tim.SetHidden();
            john.JoinChatroom(chatRoom);
            tim.JoinChatroom(chatRoom);
            ann.JoinChatroom(chatRoom);
            jill.JoinChatroom(chatRoom);
            ann.SetHidden();

            var iterator = chatRoom.GetIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.ReadKey();

        }
    }
}
