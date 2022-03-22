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
            
                var boolValue = "TODO";
                Console.WriteLine(boolValue);
            }

            Console.WriteLine();

            foreach (var item in data)
            {
                var result = "TODO";
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}