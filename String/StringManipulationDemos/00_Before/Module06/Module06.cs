using System;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void Start()
        {
            var loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine("MODULE 6");
                Console.WriteLine("Which demo do you wish to execute?");
                Console.WriteLine();
                Console.WriteLine("'1' Concatenating with operators");
                Console.WriteLine("'2' Composite formatting");
                Console.WriteLine("'3' Composite formatting (with format strings)");
                Console.WriteLine("'4' Composite formatting (with alignment)");
                Console.WriteLine("'5' String.Concat and String.Join");
                Console.WriteLine("'6' String Insertion");
                Console.WriteLine("'7' String Interpolation");

                Console.WriteLine();
                Console.WriteLine("Type 'r' to return to main menu.");
                Console.WriteLine("Type 'e' to exit.");
                Console.WriteLine();

                Console.Write(">> ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        ConcatenateWithOperators();
                        break;
                    case "2":
                        CompositeFormattingOne();
                        break;
                    case "3":
                        CompositeFormattingTwo();
                        break;
                    case "4":
                        CompositeFormattingThree();
                        break;
                    case "5":
                        StringConcatAndJoin();
                        break;
                    case "6":
                        StringInsert();
                        break;
                    case "7":
                        StringInterpolation();
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