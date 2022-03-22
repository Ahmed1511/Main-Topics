using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void StringInterpolation()
        {
            Console.Clear();

            var temperature = new Random().NextDouble() * 20;

            Console.WriteLine($"At {DateTime.Now:d} the temperature is {temperature:F2}°C");
            Console.WriteLine();

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };

            FormattableString formattableString = $"At {DateTime.Now:d} the temperature is {temperature:F2}°C";

            foreach (var culture in cultures)
            {
                Console.WriteLine(formattableString.ToString(culture));
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}