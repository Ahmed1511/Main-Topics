using System;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void StringConcatAndJoin()
        {
            Console.Clear();

            var words = new string[5];
            Console.WriteLine("Provide 5 words:");

            for (var i = 0; i < words.Length; i++)
            {
                Console.Write(">> ");
                words[i] = Console.ReadLine();
            }

            var finalSentence = string.Empty;
            // TODO

            Console.WriteLine(finalSentence);
            Console.WriteLine();
            Console.WriteLine("TODO");
            Console.WriteLine();
            Console.WriteLine("TODO");
            Console.WriteLine();
            
            Console.WriteLine("TODO");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}