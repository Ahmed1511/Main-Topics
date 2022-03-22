using System;

namespace StringManipulationDemos
{
    public partial class Module10
    {
        public static void StringLength()
        {
            Console.Clear();

            const string letterA = "a";
            const string smiley = "😊";

            Console.WriteLine($"a: {letterA.Length}");
            Console.WriteLine($"😊: {smiley.Length}");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}