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
                sb.Append(a).Append(',');
                ResetWordScreen();
            }
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine();
            sb.Append("Some more text!");

            Console.WriteLine(sb.ToString());

            sb.Clear();

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            var temperature = new Random().NextDouble() * 20;

            foreach (var culture in cultures)
            {
                sb.AppendFormat(culture, "At {0:d}, the temp is {1:F2}°C", DateTime.Now, temperature);
                sb.AppendLine();
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