using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        // Create string from char array
        public static void StringFromCharArray()
        {
            Console.Clear();

            var characters = new[] { 'c', 'h', 'a', 'r', 's' };

            var characterString = new string(characters);
            Console.WriteLine(characterString);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        // Create a string from a repeated char
        public static void RepeatingCharsInString()
        {
            Console.Clear();

            Console.Write("Provide a title >> ");
            var input = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(input);

            Console.WriteLine(new string('-', input.Length));

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}