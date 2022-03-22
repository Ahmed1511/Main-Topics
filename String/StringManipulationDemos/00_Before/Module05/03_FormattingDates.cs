using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public static void FormattingDates()
        {
            Console.Clear();
            
            var cultures = new [] { 
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            var dateTime = new DateTime(2020, 03, 28, 07, 39, 54, 123);

            foreach (var culture in cultures)
            {
                Console.WriteLine(culture);
                Console.WriteLine("TODO");
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }

   
}