using System;
using System.Linq;
using System.Text;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        public static void StringBuilderFour()
        {
            Console.Clear();

            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            var keywords = new string[25];
            for (var i = 0; i < 25; i++)
            {
                keywords[i] = new string(Enumerable.Range(1, random.Next(5, 10)).Select(_ => chars[random.Next(chars.Length)]).ToArray());
            }

            // TODO

            foreach (var keyword in keywords)
            {
                // TODO
            }

            Console.Write("TODO");
            Console.WriteLine();
            Console.WriteLine();

            // TODO

            Console.Write("TODO");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}