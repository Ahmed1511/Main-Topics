using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingNumbers()
        {
            Console.Clear();

            const string aNumber = "123456";
            var intNumber = Convert.ToInt32(aNumber);
            Console.WriteLine($"{aNumber} -> {intNumber}");
            
            intNumber = int.Parse(aNumber);
            Console.WriteLine($"{aNumber} -> {intNumber * 2}");

            var data = new[]
            {
                "101",
                "15.90",
                " -3,105",
                "1234567890123456789",
                "This is not a number!"
            };

            Console.WriteLine();

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                try
                {
                    intNumber = int.Parse(item);
                    Console.WriteLine(intNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not valid for conversion to an integer");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too larger for conversion to an integer");
                }
            }

            Console.WriteLine();
            Console.WriteLine("INT:");

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                var result = int.TryParse(item, NumberStyles.Any, CultureInfo.CurrentCulture, out var theNumber) ? $"{theNumber}" : "skipped";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("DOUBLE:");

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                var result = double.TryParse(item, out var theNumber) ? $"{theNumber}" : "skipped";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}