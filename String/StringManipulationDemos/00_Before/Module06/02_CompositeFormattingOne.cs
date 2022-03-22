using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void CompositeFormattingOne()
        {
            Console.Clear();

            Console.Write("What is your first name? ");
            var firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            var lastName = Console.ReadLine();

            var finalWelcome = "TODO";

            Console.WriteLine(finalWelcome);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}