using System;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 5");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();

                Console.WriteLine("'1' Formatting numbers (one)");
                Console.WriteLine("'2' Formatting numbers (two)");
                Console.WriteLine("'3' Formatting dates");
                Console.WriteLine("'4' Formatting enums");
                Console.WriteLine("'5' Formatting GUIDs");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        FormattingNumbersOne();
                        break;
                    case "2":
                        FormattingNumbersTwo();
                        break;
                    case "3":
                        FormattingDates();
                        break;
                    case "4":
                        FormattingEnums();
                        break;
                    case "5":
                        FormattingGuids();
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