using System;

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

            var byteLength = -1; // TODO
            Console.WriteLine($"String char length: {input.Length}");
            Console.WriteLine($"Bytes required: {byteLength}");

            Console.WriteLine();
            var data = new byte[0]; // TODO
            Console.WriteLine("Encoded bytes:");
            Console.WriteLine(BitConverter.ToString(data));

            Console.WriteLine();
            var decodedString = "TODO";
            Console.WriteLine($"Decoded string: {decodedString}");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}