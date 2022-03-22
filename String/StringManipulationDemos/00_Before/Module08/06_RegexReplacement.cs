using System;

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

            // TODO

            foreach (var entry in data)
            {
                Console.WriteLine(entry);
                Console.WriteLine("TODO");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}