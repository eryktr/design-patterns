using System;
using System.Collections.Generic;

namespace Composite.Customer
{
    internal class Customer : ICustomer
    {
        public Customer(string name)
        {
            Name = name;
            Messages = new List<Message>();
        }

        public List<Message> Messages { get; }
        public string Name { get; }


        public void Notify(Message message)
        {
            Console.WriteLine($"Customer {Name} received the message!");
            Messages.Add(message);
        }
    }
}
