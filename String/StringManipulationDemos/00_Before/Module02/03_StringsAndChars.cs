using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        // Create string from char array
        public static void StringFromCharArray()
        {
            var characters = new[] { 'c', 'h', 'a', 'r', 's' };
            
            // TODO - Create string

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        // Create a string from a repeated char
        public static void RepeatingCharsInString()
        {
            Console.Write("Provide a title >> ");
            var input = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(input);
            
            // TODO - Underline title

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}