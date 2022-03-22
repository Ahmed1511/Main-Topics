using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingDatesAndTimes()
        {
            Console.Clear();

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            var data = new[]
            {
                "2020-05-06T12:30:00.0000000+02:00",
                "05/06/2020",
                "January 15, 2021",
                "March 2018",
                "15-11-2020 10:30 AM"
            };

            foreach (var culture in cultures)
            {
                Console.WriteLine(culture);
                foreach (var date in data)
                {
                    Console.WriteLine("TODO");
                }
                Console.WriteLine();
            }

            Console.WriteLine("en-US parse exact:");
            foreach (var date in data)
            {
                Console.WriteLine("TODO");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}