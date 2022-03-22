using System;
using System.Threading;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void CompareEnglish()
        {
            Console.Clear();
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.DisplayName);
            Console.WriteLine();

            const string helloOne = "HELLO";
            const string helloTwo = "hello";
            Console.WriteLine(helloOne);
            Console.WriteLine(helloTwo);
            Console.WriteLine();

            // TODO - Comparisons

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        public static void CompareWithHyphen()
        {
            Console.Clear();
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.DisplayName);
            Console.WriteLine();

            Console.WriteLine("co-operate and cooperate current culture");
            var comparison = string.Compare("co-operate", "cooperate", StringComparison.CurrentCulture);
            Console.WriteLine(comparison);
            Console.WriteLine("co-operate and cumulative current culture");
            comparison = string.Compare("co-operate", "cumulative", StringComparison.CurrentCulture);
            Console.WriteLine(comparison);
            Console.WriteLine("co-operate and code current culture");
            comparison = string.Compare("co-operate", "code", StringComparison.CurrentCulture);
            Console.WriteLine(comparison);

            Console.WriteLine("co-operate and cooperate ordinal");
            comparison = string.Compare("co-operate", "cooperate", StringComparison.Ordinal);
            Console.WriteLine(comparison);
            Console.WriteLine("co-operate and cumulative ordinal");
            comparison = string.Compare("co-operate", "cumulative", StringComparison.Ordinal);
            Console.WriteLine(comparison);
            Console.WriteLine("co-operate and code current ordinal");
            comparison = string.Compare("co-operate", "code", StringComparison.Ordinal);
            Console.WriteLine(comparison);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}