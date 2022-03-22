using System;
using System.Text.RegularExpressions;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void RegexReplacement()
        {
            Console.Clear();

            var data = new[]
            {
                "1. Joe Bloggs",
                "Michael Smith",
                "8. Jo Simpson",
                "10.David Clarke"
            };

            const string regexPattern = "^[0-9]{1,2}\\. ?";

            foreach (var entry in data)
            {
                Console.WriteLine(entry);
                Console.WriteLine(Regex.Replace(entry, regexPattern, string.Empty));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}