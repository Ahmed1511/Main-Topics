using System;

namespace StringManipulationDemos
{
    public partial class Module04
    {
        public static void FindWithinStrings()
        {
            Console.Clear();

            var data = new[]
            {
                "Make: Ford, Model: Fiesta",
                "make: Punto",
                "Ferrari f40, car",
                "1. ford"
            };

            foreach (var entry in data)
            {
                Console.WriteLine(entry);

                var isFord = entry.Contains("Ford", StringComparison.Ordinal);
                Console.WriteLine(isFord ? "CONTAINS Ford" : "DOES NOT CONTAIN Ford");

                isFord = entry.Contains("Ford", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine(isFord ? "CONTAINS Ford (Ignore case)" : "DOES NOT CONTAIN Ford (Ignore case)");

                var isValid = entry.StartsWith("make:", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine(isValid ? "IS valid" : "IS NOT valid");

                var containsComma = entry.Contains(',', StringComparison.Ordinal);
                Console.WriteLine(containsComma ? "HAS comma" : "DOES NOT have comma");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}