using System;
using System.Globalization;
using System.Threading;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void EqualsMethodGerman()
        {
            Console.Clear();

            var initialCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine();
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine();

            var footballOne = "fussball";
            var footballTwo = "fußball";
            var footballThree = "fu\u00DFball";
            Console.WriteLine(footballOne);
            Console.WriteLine(footballTwo);
            Console.WriteLine(footballThree);
            Console.WriteLine();

            Console.WriteLine(footballOne.Equals(footballTwo));
            Console.WriteLine(footballOne.Equals(footballTwo, StringComparison.CurrentCulture));
            Console.WriteLine(footballOne.Equals(footballThree, StringComparison.CurrentCulture));

            CultureInfo.CurrentCulture = initialCulture; // return culture to original
            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}