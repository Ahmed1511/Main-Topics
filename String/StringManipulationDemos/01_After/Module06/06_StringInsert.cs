using System;

namespace StringManipulationDemos
{
    public partial class Module06
    {
        public static void StringInsert()
        {
            Console.Clear();

            var original = "Your greeting is: !";

            Console.Write("Provide a greeting >> ");
            var greeting = Console.ReadLine();

            Console.WriteLine(original.Insert(original.IndexOf('!'), greeting));

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}