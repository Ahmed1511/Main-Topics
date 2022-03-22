using System;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void ChangingCase()
        {
            Console.Clear();

            const string name = "Steve Gordon";

            var upper = "TODO";
            Console.WriteLine(upper);

            var lower = "TODO";
            Console.WriteLine(lower);

            const char letterA = 'a';
            Console.WriteLine("TODO");
            
            const string jsonName = "sports_car_manufacturer";
            
            var intermediateName = "TODO";
            Console.WriteLine(intermediateName.Replace("_", string.Empty));
            
            const string sentence = "This is a short sentence.";
            
            Console.WriteLine("TODO");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}