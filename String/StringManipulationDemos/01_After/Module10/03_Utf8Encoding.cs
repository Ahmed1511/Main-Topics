using System;
using System.Text;

namespace StringManipulationDemos
{
    public partial class Module10
    {
        public static void Utf8Encoding()
        {
            Console.Clear();

            var input = "Some text which includes an emoji 🔥";
            Console.WriteLine($"Encoding: {input}");
            Console.WriteLine();

            var byteLength = Encoding.UTF8.GetByteCount(input);
            Console.WriteLine($"String char length: {input.Length}");
            Console.WriteLine($"Bytes required: {byteLength}");

            Console.WriteLine();
            var data = Encoding.UTF8.GetBytes(input);
            Console.WriteLine("Encoded bytes:");
            Console.WriteLine(BitConverter.ToString(data));

            Console.WriteLine();
            var decodedString = Encoding.UTF8.GetString(data);
            Console.WriteLine($"Decoded string: {decodedString}");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}