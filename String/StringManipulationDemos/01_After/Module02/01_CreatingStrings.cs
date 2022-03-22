using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        public static void CreatingStrings()
        {
            Console.Clear();

            System.String firstString = new System.String("first");

            String secondString = "second";

            string thirdString = "third";

            var forthString = "forth";
            var anotherForthString = "forth";
            forthString = null;
            forthString = "";
            forthString = string.Empty;

            const string fifthString = "fifth";
            //fifthString = null;

            var withQuotesOne = "He said \"hello\"";
            var pathOne = "c:\\MyFolder";
            var pathTwo = @"c:\MyFolder";
            var withQuotesTwo = @"He said ""hello""";

            Console.WriteLine(StringConstants.RootPath);
            
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
            Console.Clear();
            
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