using System;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingNumbers()
        {
            Console.Clear();

            const string aNumber = "123456";
            var intNumber = "TODO";
            Console.WriteLine($"{aNumber} -> {intNumber}");
            
            intNumber = "TODO";
            Console.WriteLine($"{aNumber} -> {intNumber}");

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
                intNumber = "TODO";
                Console.WriteLine(intNumber);
            }

            Console.WriteLine();
            Console.WriteLine("INT:");

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                var result = "TODO";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("DOUBLE:");

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                var result = "TODO";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}