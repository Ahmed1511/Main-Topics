using System;
using System.Globalization;

namespace StringManipulationDemos
{
    public partial class Module08
    {
        public static void ChangingCase()
        {
            Console.Clear();

            const string name = "Steve Gordon";

            //var upper = name.ToUpper(CultureInfo.InvariantCulture);
            var upper = name.ToUpperInvariant();
            Console.WriteLine(upper);

            var lower = name.ToLowerInvariant();
            Console.WriteLine(lower);

            const char letterA = 'a';
            Console.WriteLine(char.ToUpperInvariant(letterA));
            
            const string jsonName = "sports_car_manufacturer";

            var textInfo = new CultureInfo("en-GB", false).TextInfo;
            var intermediateName = textInfo.ToTitleCase(jsonName);
            Console.WriteLine(intermediateName.Replace("_", string.Empty));
            
            const string sentence = "This is a short sentence.";
            
            Console.WriteLine(textInfo.ToTitleCase(sentence));

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}