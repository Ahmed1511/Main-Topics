using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void SortingDanish()
        {
            Console.Clear();
            var initialCulture = CultureInfo.CurrentCulture;
            
            var strings = new SortedSet<string> { "brug", "æbler" };

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            var comparer = StringComparer.Create(new CultureInfo("da-DK"), CompareOptions.None);
            strings = new SortedSet<string>(comparer) { "brug", "æbler" };

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            CultureInfo.CurrentCulture = new CultureInfo("da-DK");
            strings = new SortedSet<string> { "brug", "æbler" };

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            CultureInfo.CurrentCulture = initialCulture; // return culture to original
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}