using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        public static void CreatingStrings()
        {
            Console.Clear();

            // TODO - String demos

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        public class StringConstants
        {
            public const string RootPath = "c:\\ImportantFiles\\Code";
        }

        // Verbatim string example with control characters
        public static void VerbatimStringWithNewlines()
        {
            var code = @"namespace MyCode
{
    public class Something
    {
    }
}";
            Console.WriteLine(code);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}