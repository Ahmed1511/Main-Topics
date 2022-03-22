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
            // TODO
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ordinal:");
            // TODO
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("OrdinalIgnoreCase:");
            // TODO
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("en-GB ignore symbols:");
            // TODO
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array.Sort");
            // TODO

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}