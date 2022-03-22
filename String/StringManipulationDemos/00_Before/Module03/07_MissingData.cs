using System;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void CheckingForMissingData()
        {
            Console.Clear();

            Console.WriteLine("Provide a string. Type '--e' to create an empty string or '--n' for a null string");
            Console.WriteLine();
            Console.Write(">> ");
            var input = Console.ReadLine();
            if (input == "--e") input = string.Empty;
            if (input == "--n") input = null;

            Console.WriteLine(input is null ? "Input WAS null" : "Input WAS NOT null");
            // danger ahead
            Console.WriteLine(input.Equals(string.Empty) ? "Input WAS empty" : "Input WAS NOT empty");
            Console.WriteLine(input == string.Empty ? "Input WAS empty" : "Input WAS NOT empty");

            //Console.WriteLine(TODO ? "Input WAS null or empty" : "Input WAS NOT null or empty");
            //Console.WriteLine(TODO ? "Input WAS null, empty or whitespace" : "Input WAS NOT null, empty or whitespace");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}