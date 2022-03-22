using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void CompositeFormattingTwo()
        {
            Console.Clear();

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            Console.Write("What is the price? >> ");
            var priceText = Console.ReadLine();

            if (decimal.TryParse(priceText, out var price))
            {
                foreach (var culture in cultures)
                {
                    var formattedPrice = "TODO";
                    Console.WriteLine(formattedPrice);
                }
            }

            Console.WriteLine();

            var temperature = new Random().NextDouble() * 20;

            foreach (var culture in cultures)
            {
                Console.WriteLine("TODO");
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}