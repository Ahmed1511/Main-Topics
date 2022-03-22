using System;

namespace StringManipulationDemos
{  
    public partial class Module02
    {
        // Working with chars
        public static void WorkingWithChars()
        {
            Console.Clear();

            System.Char firstChar = '1';

            char secondChar = '2';

            var thirdChar = '3';

            const char forthChar = '4';

            char defaultChar = default; // '\0'

            var letterH = 'H';
            Console.Write(letterH);

            letterH = '\u0048';
            Console.Write(letterH);

            letterH = '\x0048';
            Console.Write(letterH);

            letterH = '\x48';
            Console.Write(letterH);

            letterH = (char)72;
            Console.Write(letterH);

            int letterHDecimal = letterH;
            Console.WriteLine(letterHDecimal);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}