using System;

namespace StringManipulationDemos
{
    public partial class Module04
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 4");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();

                Console.WriteLine("'1' Finding text within strings");
                Console.WriteLine("'2' Locating text within strings");
                Console.WriteLine("'3' RegEx matches");
                Console.WriteLine("'4' Searching with ReadOnlySpan");
                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        FindWithinStrings();
                        break;
                    case "2":
                        LocatingWithinStrings();
                        break;
                    case "3":
                        RegularExpressions();
                        break;
                    case "4":
                        ReadOnlySpan();
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