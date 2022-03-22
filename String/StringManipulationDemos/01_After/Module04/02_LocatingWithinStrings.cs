using System;

namespace StringManipulationDemos
{
    public partial class Module04
    {
        public static void LocatingWithinStrings()
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

                var colonPosition = entry.IndexOf(':', StringComparison.Ordinal);
                Console.WriteLine("First colon: " + colonPosition);

                var startAt = colonPosition + 1;
                colonPosition = entry.IndexOf(':', startAt, entry.Length - startAt);
                Console.WriteLine("Next colon: " + colonPosition);

                colonPosition = entry.LastIndexOf(':');
                Console.WriteLine("Last colon: " + colonPosition);

                var colonCommaPosition = entry.IndexOfAny(new[] { ',', ':' });
                Console.WriteLine("Colon/comma: " + colonCommaPosition);

                var modelPosition = entry.IndexOf("model", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine("model: " + modelPosition);
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}