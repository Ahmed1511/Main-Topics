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

            Console.WriteLine(string.Format("At {0:d} the temperature is {1:F2}°C", DateTime.Now, temperature));
            Console.WriteLine();

            var cultures = new[] {
                new CultureInfo("en-US"),
                new CultureInfo("de-DE"),
                new CultureInfo("ja-JP")
            };
            
            foreach (var culture in cultures)
            {
                Console.WriteLine("TODO");
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}