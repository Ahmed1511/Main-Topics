using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void SplittingStringsUsingRegex()
        {
            Console.Clear();

            var ipData = new[]
            {
                "192.168.0.1",
                "127.0.0.1",
                "0800 123 4567",
            };

            // TODO

            foreach (var entry in ipData)
            {
                Console.WriteLine(entry);

                // TODO

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}