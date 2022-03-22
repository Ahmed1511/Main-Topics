using System;
using System.Globalization;
using System.Linq;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void SortingStrings()
        {
            Console.Clear();
            Console.WriteLine(CultureInfo.CurrentCulture);
            Console.WriteLine();

            var strings = new[]
            {
                "banana",
                "apple",
                "Lemon",
                "Apple",
                "grapes",
                "Banana",
                "lemon",
                "Grapes",
                ".grapes"
            };

            Console.WriteLine("Default:");
            var sorted = strings.OrderBy(s => s);
            foreach (var s in sorted)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ordinal:");
            sorted = strings.OrderBy(s => s, StringComparer.Ordinal);
            foreach (var s in sorted)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("OrdinalIgnoreCase:");
            sorted = strings.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            foreach (var s in sorted)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("en-GB ignore symbols:");
            var sc = StringComparer.Create(new CultureInfo("en-GB"), CompareOptions.IgnoreSymbols);
            sorted = strings.OrderBy(s => s, sc);
            foreach (var s in sorted)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array.Sort");
            Array.Sort(strings, sc);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}