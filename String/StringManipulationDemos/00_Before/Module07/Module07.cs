using System;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 7");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                Console.WriteLine("'1' Getting started with StringBuilders");
                Console.WriteLine("'2' Constructor overloads");
                Console.WriteLine("'3' Working with StringBuilders (One)");
                Console.WriteLine("'4' Working with StringBuilders (Two)");
                Console.WriteLine("'5' Pooling StringBuilders");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        StringBuilderOne();
                        break;
                    case "2":
                        StringBuilderTwo();
                        break;
                    case "3":
                        StringBuilderThree();
                        break;
                    case "4":
                        StringBuilderFour();
                        break;
                    case "5":
                        PoolingStringBuilders();
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