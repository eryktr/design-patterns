using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class CentDisposer : Disposer
    {
        public CentDisposer(int value) : base(value)
        {
        }

        public override void Process(ref int dollars, ref int cents)
        {
            while (cents >= Value)
            {
                Counter++;
                cents -= Value;
            }
        }

        public override void PrintMessage()
        {
            Console.WriteLine($"Number of $0.{Value} coins: {Counter}");
        }
    }
}