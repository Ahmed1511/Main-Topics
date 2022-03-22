using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        public static void CasingChars()
        {
            const char letterH = 'H';

            // TODO - Lowercase 'h'

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        public static void CharInfo()
        {
            var characters = new[] { 'a', '1', ' ', '.' };

            Console.WriteLine(characters);
            Console.WriteLine();

            foreach (var character in characters)
            {
                Console.Write(character);
                Console.Write(" is ");

                if (char.IsLetter(character))
                    Console.Write("letter |");

                if (char.IsDigit(character))
                    Console.Write("digit |");

                if (char.IsWhiteSpace(character))
                    Console.Write("whitespace |");

                if (char.IsPunctuation(character))
                    Console.Write("punctuation |");

                if (char.IsSeparator(character))
                    Console.Write("separator |");

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}