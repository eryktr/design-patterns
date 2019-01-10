using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var c10000 = new HarmonicSeriesCalculator(10000);
            var c100000 = new HarmonicSeriesCalculator(100000);
            var c1000000 = new HarmonicSeriesCalculator(1000000);
            c10000.Execute();
            c100000.Execute();
            c1000000.Execute();

        }
    }
}
