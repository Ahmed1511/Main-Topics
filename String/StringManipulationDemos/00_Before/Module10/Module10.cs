using System;

namespace StringManipulationDemos
{
    public partial class Module10
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 10");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                Console.WriteLine("'1' Emoji length");
                Console.WriteLine("'2' ASCII encoding");
                Console.WriteLine("'3' UTF-8 encoding");
                Console.WriteLine("'4' Runes and Grapheme Clusters");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        StringLength();
                        break;
                    case "2":
                        AsciiEncoding();
                        break;
                    case "3":
                        Utf8Encoding();
                        break;
                    case "4":
                        Runes();
                        break;
                    case "r":
                        loop = false;
                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}