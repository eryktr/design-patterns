using System;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportBuilder builder = new XMLReportBuilder("Hello, world!");
            builder.SetAuthor("myself");
            builder.SetTopic("programming");
            builder.SetDate(DateTime.Now);
            var report = builder.BuildReport();
            Console.WriteLine(report.ToString());
            Console.ReadKey();

            ReportBuilder builder2 = new JSONReportBuilder("Hello, world!");
            builder2.SetAuthor("myself");
            builder2.SetDate(DateTime.Today);
            var report2 = builder2.BuildReport();
            Console.WriteLine(report2.ToString());
            Console.ReadKey();
        }
    }
}
