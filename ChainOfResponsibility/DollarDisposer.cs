using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ChainOfResponsibility
{
    class DollarDisposer : Disposer
    {
        public DollarDisposer(int value) : base(value)
        {
        }

        public override void Process(ref int dollars, ref int cents)
        {
            while (dollars >= Value)
            {
                Counter++;
                dollars -= Value;
            }
        }

        public override void PrintMessage()
        {
            Console.WriteLine($"Number of ${Value} bills: {Counter}");
        }
    }
}