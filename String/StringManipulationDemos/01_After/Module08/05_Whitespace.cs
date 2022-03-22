using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void Whitespace()
        {
            Console.Clear();

            const string someText = "   This is a string with whitespace        ";

            var withoutWhitespace = someText.Trim();
            Console.WriteLine($"{withoutWhitespace}END");

            withoutWhitespace = someText.TrimStart();
            Console.WriteLine($"{withoutWhitespace}END");

            withoutWhitespace = someText.TrimEnd();
            Console.WriteLine($"{withoutWhitespace}END");

            const string codeComment = "/// This is a code comment ";

            var charsToTrim = new[] { '/', ' ' };
            var trimmed = codeComment.Trim(charsToTrim);
            Console.WriteLine(trimmed);

            var data = new[] {"Cat", "Dog", "House", "Centipede"};

            foreach (var item in data)
            {
                Console.WriteLine(item.PadLeft(15, ' '));
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}