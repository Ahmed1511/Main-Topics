using System;
using System.Collections.Generic;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        public static void StringBuilderOne()
        {
            Console.Clear();
            
            var data = FakeApiCall();

            foreach (var sentence in data)
            {
                // TODO
            }

            // TODO

            Console.WriteLine("TODO");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }

        private static IEnumerable<string> FakeApiCall()
        {
            return new List<string>
            {
                "This is the first sentence. ",
                "This is the second sentence. ",
                "This is the third sentence. ",
                "This is the forth sentence. ",
                "This is the fifth sentence. "
            };
        }
    }
}