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

            const string startsWithPattern = "^[A-Za-z]";
            const string matchPattern = ": (\\w+),";

            foreach (var entry in data)
            {
                Console.WriteLine(entry);

                var match = Regex.Match(entry, startsWithPattern);
                Console.WriteLine(match.Success ? "STARTS with text" : "DOES NOT START with text");

                match = Regex.Match(entry, matchPattern);
                Console.WriteLine(match.Success ? "VALID" : "NOT VALID");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}