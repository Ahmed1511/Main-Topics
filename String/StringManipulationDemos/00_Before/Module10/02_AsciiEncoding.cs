using System;

namespace StringManipulationDemos
{
    public partial class Module10
    {
        public static void AsciiEncoding()
        {
            Console.Clear();

            var input = "Some text to encode";
            Console.WriteLine($"Encoding: {input}");
            Console.WriteLine();

            Console.WriteLine();

            var byteLength = -1; // TODO
            Console.WriteLine($"String char length: {input.Length}");
            Console.WriteLine($"Bytes required: {byteLength}");

            Console.WriteLine();
            var data = new byte[byteLength];
            // TODO
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