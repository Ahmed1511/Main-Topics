using System;
using System.Text.RegularExpressions;

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

            const string ipPattern = "^([0-9]{1,3})\\.([0-9]{1,3})\\.([0-9]{1,3})\\.([0-9]{1,3})$";

            foreach (var entry in ipData)
            {
                Console.WriteLine(entry);

                var parts = Regex.Split(entry, ipPattern);
                foreach(var part in parts)
                {
                    Console.WriteLine(part);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}