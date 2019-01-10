using System;
using System.Collections.Generic;
using Composite.Customer;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customers = new List<ICustomer>();
            var john = new Customer.Customer("john");
            var tim = new Customer.Customer("tim");
            var company = new CompositeCustomer("company");
            var ceo = new Customer.Customer("ceo");
            var team = new CompositeCustomer("team");
            var kate = new Customer.Customer("kate");
            var jill = new Customer.Customer("jill");
            var message = new Message("Hello", "World");
            team.AddCustomers(kate, jill);
            company.AddCustomers(ceo, team);

            customers.Add(john);
            customers.Add(tim);
            customers.Add(company);

            foreach (var customer in customers)
            {
                customer.Notify(message);
            }

            Console.ReadKey();


        }
    }
}