using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module10
    {
        public static void Runes()
        {
            Console.Clear();

            var input = "👩🏽‍🚒";
            Console.WriteLine($"Analysis of: {input}");

            Console.WriteLine();
            Console.WriteLine("Chars:");

            var counter = 0;
            foreach (var character in input)
            {
                counter++;
                Console.WriteLine(character);
            }
            Console.WriteLine($"Total chars: {counter}");

            Console.WriteLine();
            Console.WriteLine("Runes:");

            counter = 0;
            foreach (var rune in input.EnumerateRunes())
            {
                counter++;
                Console.WriteLine(rune);
            }
            Console.WriteLine($"Total runes: {counter}");

            Console.WriteLine();
            var stringInfo = new StringInfo(input);
            Console.WriteLine($"Total text elements: {stringInfo.LengthInTextElements}");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}