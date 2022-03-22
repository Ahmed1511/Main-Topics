using System;
using System.Globalization;

namespace StringManipulationDemos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Which module do you wish to execute?");
                Console.WriteLine();

                Console.WriteLine("MODULES");
                Console.WriteLine("--------");
                Console.WriteLine("'2' Module 2: The String and Char Types");
                Console.WriteLine("'3' Module 3: Comparing Strings");
                Console.WriteLine("'4' Module 4: Searching Strings");
                Console.WriteLine("'5' Module 5: Formatting Types as Strings");
                Console.WriteLine("'6' Module 6: Concatenating and Formatting Strings");
                Console.WriteLine("'7' Module 7: Efficient String Concatenation");
                Console.WriteLine("'8' Module 8: Modifying Strings");
                Console.WriteLine("'9' Module 9: Parsing Strings");
                Console.WriteLine("'10' Module 10: String Encoding in .NET");
                
                Console.WriteLine();
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "2":
                        Module02.Start();
                        break;
                    case "3":
                        Module03.Start();
                        break;
                    case "4":
                        Module04.Start();
                        break;
                    case "5":
                        Module05.Start();
                        break;
                    case "6":
                        Module06.Start();
                        break;
                    case "7":
                        Module07.Start();
                        break;
                    case "8":
                        Module08.Start();
                        break;
                    case "9":
                        Module09.Start();
                        break;
                    case "10":
                        Module10.Start();
                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
