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
                keywords[i] = new string(Enumerable.Range(1, random.Next(5, 10))
                    .Select(_ => chars[random.Next(chars.Length)]).ToArray());
            }

            var sb = new StringBuilder("This is a string builder with random keywords:");
            sb.AppendLine();

            foreach (var keyword in keywords)
            {
                sb.Append(keyword).Append(',');
            }

            Console.Write(sb.ToString());
            Console.WriteLine();
            Console.WriteLine();

            sb.Replace(',', '|');
            sb.Insert(0, "Here's a new sentence at the start!! ");

            Console.Write(sb.ToString());

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}