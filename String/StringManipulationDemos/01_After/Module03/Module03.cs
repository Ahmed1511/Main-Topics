using System;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 3");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                
                Console.WriteLine("'1' Compare English strings");
                Console.WriteLine("'2' Compare with hyphen");
                Console.WriteLine("'3' Sorting strings");
                Console.WriteLine("'4' Sorting Danish");
                Console.WriteLine("'5' String.Equals");
                Console.WriteLine("'6' String.Equals with German strings");
                Console.WriteLine("'7' String equality operators");
                Console.WriteLine("'8' Checking for missing data");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        CompareEnglish();
                        break;
                    case "2":
                        CompareWithHyphen();
                        break;
                    case "3":
                        SortingStrings();
                        break;
                    case "4":
                        SortingDanish();
                        break;
                    case "5":
                        EqualsMethod();
                        break;
                    case "6":
                        EqualsMethodGerman();
                        break;
                    case "7":
                        EqualityOperator();
                        break;
                    case "8":
                        CheckingForMissingData();
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