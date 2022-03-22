using System;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public static void FormattingGuids()
        {
            Console.Clear();

            var guid = Guid.NewGuid();

            Console.WriteLine(guid.ToString());
            Console.WriteLine(guid.ToString("D"));
            Console.WriteLine(guid.ToString("N"));
            Console.WriteLine(guid.ToString("B"));
            Console.WriteLine(guid.ToString("P"));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}