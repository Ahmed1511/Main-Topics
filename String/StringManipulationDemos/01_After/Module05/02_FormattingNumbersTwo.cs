using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public static void FormattingNumbersTwo()
        {
            Console.Clear();
            
            var cultures = new [] { 
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };
        
            var percent = .2569;
            foreach (var culture in cultures)
            {
                Console.WriteLine(culture);
                Console.WriteLine(percent.ToString("P", culture));
                Console.WriteLine();
            }
            
            Console.WriteLine(15988.ToString("D8"));
            Console.WriteLine();

            var temps = new [] {31.25, -5.1, 0.0};
            foreach (var temp in temps)
            {
                Console.WriteLine(temp
                    .ToString("#.# 'degrees Celsius';#.# 'degrees below zero';'Freezing'"));
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}