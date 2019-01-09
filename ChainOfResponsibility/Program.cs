using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Disposer d100 = new DollarDisposer(100);
            Disposer d50 = new DollarDisposer(50);
            Disposer d20 = new DollarDisposer(20);
            Disposer d10 = new DollarDisposer(10);
            Disposer d5 = new DollarDisposer(5);
            Disposer d1 = new DollarDisposer(1);
            Disposer c50 = new CentDisposer(50);
            Disposer c25 = new CentDisposer(25);
            Disposer c10 = new CentDisposer(10);
            Disposer c5 =  new CentDisposer(5);
            Disposer c1 =  new CentDisposer(1);

            d100.SetNext(d50);
            d50.SetNext(d20);
            d20.SetNext(d10);
            d10.SetNext(d5);
            d5.SetNext(d1);
            d1.SetNext(c50);
            c50.SetNext(c25);
            c25.SetNext(c10);
            c10.SetNext(c5);
            c5.SetNext(c1);

            d100.Dispose(1213, 72);
            Console.ReadKey();
        }
    }
}
