using System;
using System.Text.RegularExpressions;

namespace StringManipulationDemos
{
    public partial class Module04
    {
        public static void RegularExpressions()
        {
            Console.Clear();

            var data = new[]
            {
                "Make: Ford, Model: Fiesta",
                "make: Punto",
                "Ferrari f40, car",
                "1. ford"
            };

            // TODO - Patterns

            foreach (var entry in data)
            {
                Console.WriteLine(entry);

                // TODO - Matches

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}