using System;
using System.Text;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        public static void StringBuilderTwo()
        {
            Console.Clear();

            const string myString = "This is a string. ";

            var sb = new StringBuilder(myString, myString.Length * 11);
            
            for (var i = 0; i < 10; i++)
            {
                sb.Append(myString);
            }
            
            Console.WriteLine($"Current length = {sb.Length}. Capacity = {sb.Capacity}.");

            //sb.Capacity = myString.Length * 41;
            sb.EnsureCapacity(myString.Length * 41);

            for (var i = 0; i < 30; i++)
            {
                sb.Append(myString);
            }

            Console.WriteLine($"Current length = {sb.Length}. Capacity = {sb.Capacity}.");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue the demo...");
            Console.ReadKey();

            sb = new StringBuilder(256, 2048);

            for (var i = 0; i < 10000; i++)
            {
                sb.Append(myString);
            }

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}