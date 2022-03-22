using System;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingBooleans()
        {
            Console.Clear();

            var data = new[]
            {
                "true",
                "false",
                "TRUE",
                "Not true",
                null
            };

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");

                try
                {
                    var boolValue = bool.Parse(item);
                    Console.WriteLine(boolValue);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Input string is null");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not valid for conversion to a boolean");
                }
            }

            Console.WriteLine();

            foreach (var item in data)
            {
                var result = bool.TryParse(item, out var theBoolean)
                    ? $"{item} -> {theBoolean}"
                    : "skipped";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}