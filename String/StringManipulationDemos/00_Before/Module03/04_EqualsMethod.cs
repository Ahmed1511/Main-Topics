using System;
using System.Threading;

namespace StringManipulationDemos
{
    public partial class Module03
    {
        public static void EqualsMethod()
        {
            Console.Clear();
            Console.WriteLine(Thread.CurrentThread.CurrentCulture);

            var helloWorld = "Hello World!";
            var helloWorldLower = "hello world!";
            Console.WriteLine(helloWorld);
            Console.WriteLine(helloWorldLower);
            Console.WriteLine();

            // TODO - Equals

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}