using System;

namespace StringManipulationDemos
{
    public partial class Module09
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 9");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                Console.WriteLine("'1' Parsing numbers");
                Console.WriteLine("'2' Parsing booleans");
                Console.WriteLine("'3' Parsing dates and times");
                Console.WriteLine("'4' Parsing other types");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        ParsingNumbers();
                        break;
                    case "2":
                        ParsingBooleans();
                        break;
                    case "3":
                        ParsingDatesAndTimes();
                        break;
                    case "4":
                        ParsingOtherTypes();
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