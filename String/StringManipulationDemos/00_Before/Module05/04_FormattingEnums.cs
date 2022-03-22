using System;

namespace StringManipulationDemos
{
    public partial class Module05
    {
        public enum Status { Red = 1, Yellow = 2, Green = 3 }

        public static void FormattingEnums()
        {
            Console.Clear();
            
            var status = Status.Yellow;
            
            Console.WriteLine("TODO");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}