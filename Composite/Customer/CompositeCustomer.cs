using System;
using System.Collections.Generic;

namespace Composite.Customer
{
    internal class CompositeCustomer : ICustomer
    {
        public CompositeCustomer(string name)
        {
            Name = name;
            Customers = new List<ICustomer>();
        }


        public List<ICustomer> Customers { get; }
        public string Name { get; }

        public void Notify(Message message)
        {
            Console.WriteLine($"Informing all customers from {Name}");
            foreach (var customer in Customers) { customer.Notify(message);}
        }

        public void AddCustomers(params ICustomer[] customers)
        {
            foreach (var customer in customers)
            {
                Customers.Add(customer);
            }
        }

        public void DeleteCustomers(params ICustomer[] customers)
        {
            foreach (var customer in customers)
            {
                Customers.Remove(customer);
            }
        }
    }
}