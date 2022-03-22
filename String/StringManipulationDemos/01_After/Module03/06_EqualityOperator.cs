using System;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void EqualityOperator()
        {
            Console.Clear();

            var helloWorld = "Hello World!";
            var helloWorldLower = "hello world!";
            Console.WriteLine(helloWorld);
            Console.WriteLine(helloWorldLower);
            Console.WriteLine();

            Console.WriteLine(helloWorld == helloWorldLower ? "equal" : "not equal");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

    }
}
