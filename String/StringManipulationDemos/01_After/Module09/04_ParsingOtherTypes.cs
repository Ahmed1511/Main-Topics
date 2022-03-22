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
                Console.WriteLine(Enum.TryParse(typeof(DayOfWeek), item, true,
                    out var dayOfWeek) ? (DayOfWeek)dayOfWeek : "Not matched");
            }
            
            // Char

            const string aLetterString = "A";

            Console.WriteLine(char.TryParse(aLetterString, out var aChar) ? aChar : "Unabled to parse");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}