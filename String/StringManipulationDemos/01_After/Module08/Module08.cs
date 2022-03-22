using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 8");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                Console.WriteLine("'1' Splitting strings");
                Console.WriteLine("'2' Splitting strings with Regex");
                Console.WriteLine("'3' Substrings");
                Console.WriteLine("'4' Changing case");
                Console.WriteLine("'5' Whitespace");
                Console.WriteLine("'6' Regex replacement");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        SplittingStrings();
                        break;
                    case "2":
                        SplittingStringsUsingRegex();
                        break;
                    case "3":
                        Substring();
                        break;
                    case "4":
                        ChangingCase();
                        break;
                    case "5":
                        Whitespace();
                        break;
                    case "6":
                        RegexReplacement();
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