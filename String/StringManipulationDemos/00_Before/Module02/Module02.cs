using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();
                
                Console.WriteLine("MODULE 2");                
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();

                Console.WriteLine("'1' Declaring and initializing strings");
                Console.WriteLine("'2' Verbatim strings with newlines and tabs");
                Console.WriteLine("'3' Working with chars");
                Console.WriteLine("'4' Create a string from a char array");
                Console.WriteLine("'5' Creating a variable length string using a repeated char");
                Console.WriteLine("'6' Changing character case");
                Console.WriteLine("'7' Getting the category of a Char");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        CreatingStrings();
                        break;
                    case "2":
                        VerbatimStringWithNewlines();
                        break;
                    case "3":
                        WorkingWithChars();
                        break;
                    case "4":
                        StringFromCharArray();
                        break;
                    case "5":
                        RepeatingCharsInString();
                        break;
                    case "6":
                        CasingChars();
                        break;
                    case "7":
                        CharInfo();
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