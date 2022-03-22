using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void Whitespace()
        {
            Console.Clear();

            const string someText = "   This is a string with whitespace        ";

            var withoutWhitespace = "TODO";
            Console.WriteLine($"{withoutWhitespace}END");

            withoutWhitespace = "TODO";
            Console.WriteLine($"{withoutWhitespace}END");

            withoutWhitespace = "TODO";
            Console.WriteLine($"{withoutWhitespace}END");

            const string codeComment = "/// This is a code comment ";

            var trimmed = "TODO";
            Console.WriteLine(trimmed);

            var data = new[] {"Cat", "Dog", "House", "Centipede"};

            foreach (var item in data)
            {
                Console.WriteLine("TODO");
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}