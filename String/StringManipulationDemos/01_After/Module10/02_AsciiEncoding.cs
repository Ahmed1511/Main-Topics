using System;
using System.Text;

namespace StringManipulationDemos 
{
    public partial class Module10
    {
        public static void AsciiEncoding()
        {
            Console.Clear();

            var input = "Some text which includes an emoji 🔥";
            Console.WriteLine($"Encoding: {input}");
            Console.WriteLine();

            Console.WriteLine();

            var byteLength = Encoding.ASCII.GetByteCount(input);
            Console.WriteLine($"String char length: {input.Length}");
            Console.WriteLine($"Bytes required: {byteLength}");

            Console.WriteLine();
            var data = new byte[byteLength];
            Encoding.ASCII.GetBytes(input, data);
            Console.WriteLine("Encoded bytes:");
            Console.WriteLine(BitConverter.ToString(data));

            Console.WriteLine();
            var decodedString = Encoding.ASCII.GetString(data);
            Console.WriteLine($"Decoded string: {decodedString}");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}