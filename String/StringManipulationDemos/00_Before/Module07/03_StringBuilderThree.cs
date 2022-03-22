using System;
using System.Globalization;
using System.Text;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        public static void StringBuilderThree()
        {
            Console.Clear();

            var sb = new StringBuilder();
            ResetWordScreen();

            string a;
            while ((a = Console.ReadLine()) != "exit")
            {
                // TODO
                ResetWordScreen();
            }
            // TODO
            Console.WriteLine("TODO");

            // TODO

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            var temperature = new Random().NextDouble() * 20;

            foreach (var culture in cultures)
            {
                // TODO
            }

            Console.WriteLine(sb.ToString());

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        private static void ResetWordScreen()
        {
            Console.Clear();
            Console.WriteLine("Provide some words, pressing enter after each word.");
            Console.WriteLine("Type 'exit' to exit.");
            Console.WriteLine();
            Console.Write(">> ");
        }
    }
}