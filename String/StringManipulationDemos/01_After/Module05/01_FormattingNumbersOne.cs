using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public static void FormattingNumbersOne()
        {
            Console.Clear();
            
            var cultures = new [] { 
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            var price = 1889.86159m;

            Console.WriteLine("Default formatting:");
            Console.WriteLine(price.ToString());
            Console.WriteLine();

            foreach (var culture in cultures)
            {
                Console.WriteLine(culture);
                Console.WriteLine(price.ToString(culture));
                Console.WriteLine(price.ToString("C", culture));
                Console.WriteLine(price.ToString("F3", culture));
                Console.WriteLine(price.ToString("N1", culture));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }

   
}