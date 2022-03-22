using System;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void ParsingOtherTypes()
        {
            Console.Clear();

            // Enum

            var data = new []
            {
                "Monday",
                "November",
                "SATURDAY"
            };

            foreach (var item in data)
            {
                Console.Write($"{item} -> ");
                Console.WriteLine("TODO");
            }
            
            // Char

            const string aLetterString = "A";

            Console.WriteLine("TODO");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}