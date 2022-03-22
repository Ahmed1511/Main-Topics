using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void Substring()
        {
            Console.Clear();

            var carData = new[]
            {
                "Make: Ferrari",
                "Model: 488",
                "Engine: Twin-Turbo 3.9L V8.",
                "Top Speed: 205 mph."
            };

            foreach (var data in carData)
            {
                var colon = data.IndexOf(": ", StringComparison.Ordinal);
             
                var start = colon + 2;
                var end = data[^1] == '.' ? data.Length - 1 : data.Length;
                
                if (start >= 0 && data.Length > start) 
                    Console.WriteLine(data[start..end]);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}