using System;

namespace Mediator
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var room = new ChatRoom();
            var tom = new User("Tom");
            var john = new User("John");
            var don = new User("don");

            tom.JoinChatRoom(room);
            john.JoinChatRoom(room);
            don.JoinChatRoom(room);

            tom.SendMessage("Hello, guys!");
            john.SendMessage("Hi ther!");
            don.SendMessage("Yo!");


        }

    
    }
}
