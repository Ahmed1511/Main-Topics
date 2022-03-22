using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //StringConvertion();
            //StringasArrray();
            //EscapeString();
            //AppendingStrings();
            //InterplationandLiteral();
            //StringBuilderDemo();
            //WorkingwithArrays();
            //PadandTrim();
            //SearchingString();
            //OrderingString();
            //EqualtoHelper();
            //GettingASubstring();
            //ReplacingText();
            //InsertText();
            RemoveText();

            Console.ReadKey();
        }

        private static void StringConvertion()
        {
            string testString = "tHis iS tHe FBI Calling!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo englishTextInfo = new CultureInfo("en-us", false).TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = currentTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);
        }
        private static void StringasArrray()
        {
            string testString = "Timothy";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }
        private static void EscapeString()
        {
            string result;
            result = "this is \"test\"";
            Console.WriteLine(result);

            result = "c:\\Demos\\test.txt";
            Console.WriteLine(result);

            result = @"c:\Demos\test.txt";
            Console.WriteLine(result);
        }
        private static void AppendingStrings()
        {
            string firstName = "Tim";
            string lastName = "Cory";

            string result = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(result);

            result = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(result);

            result = $"{firstName}, my name is {firstName} {lastName} ";
            Console.WriteLine(result);
        }
        private static void InterplationandLiteral()
        {
            string testName = "tim cory";
            string result = $@"C:\Demos\{testName}\{"\""} test{"\""}.txt";
            Console.WriteLine(result);
        }
        private static void StringBuilderDemo()
        {
            Stopwatch regularStopWatch = new Stopwatch();
            regularStopWatch.Start();

            string test = "";
            for (int i = 0; i < 10000; i++)
            {
                test += i;
            }

            regularStopWatch.Stop();
            Console.WriteLine($"Regular Stop Watch :{regularStopWatch.ElapsedMilliseconds}ms");

            // StringBuilder
            Stopwatch builderStopWatch = new Stopwatch();
            builderStopWatch.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }

            builderStopWatch.Stop();
            Console.WriteLine($"Builder Stop Watch :{builderStopWatch.ElapsedMilliseconds}ms");
        }
        private static void WorkingwithArrays()
        {
            int[] ages = new int[] { 10, 20, 30, 40 };
            string result;
            result = string.Concat(ages);
            Console.WriteLine(result);

            result = string.Join(",", ages);
            Console.WriteLine(result);
            Console.WriteLine();

            string testString = "john,tim,cory,bob,jan";
            string[] resultArray = testString.Split(',');
            Array.ForEach(resultArray, X => Console.WriteLine(X));
            Console.WriteLine();

            testString = "john, tim, cory, bob, jan";
            resultArray = testString.Split(", ");
            Array.ForEach(resultArray, X => Console.WriteLine(X));
            Console.WriteLine();



        }
        private static void PadandTrim()
        {
            string testString = "      Hello World     ";
            string result;

            result = testString.TrimStart();
            Console.WriteLine($"'{result}'");

            result = testString.TrimEnd();
            Console.WriteLine($"'{result}'");

            result = testString.Trim();
            Console.WriteLine($"'{result}'");

            Console.WriteLine();

            testString = "1.15";
            result = testString.PadLeft(9, '*');
            Console.WriteLine(result);

            result = testString.PadRight(9, '*');
            Console.WriteLine(result);



        }
        private static void SearchingString()
        {
            string testString = "this is a test for search. let's see how it test work out.";
            bool resultBool;
            int resultInt;

            resultBool = testString.StartsWith("this is");
            Console.WriteLine($" Start with \"this is\" : {resultBool}");

            resultBool = testString.StartsWith("thIs is");
            Console.WriteLine($" Start with \"this is\" : {resultBool}");
            Console.WriteLine();

            resultBool = testString.EndsWith("work out.");
            Console.WriteLine($" End with \"work out\" : {resultBool}");

            resultBool = testString.EndsWith("work oUt.");
            Console.WriteLine($" End with \"work out\" : {resultBool}");
            Console.WriteLine();

            resultBool = testString.Contains("work out.");
            Console.WriteLine($" contain \"work out\" : {resultBool}");

            resultBool = testString.Contains("work Out.");
            Console.WriteLine($" contain \"work out\" : {resultBool}");
            Console.WriteLine();

            resultInt = testString.IndexOf("test");
            Console.WriteLine($"index of 'test' { resultInt}");

            resultInt = testString.IndexOf("test", 11);
            Console.WriteLine($"index of 'test' after character 10 :  { resultInt}");

            resultInt = testString.IndexOf("test", 50);
            Console.WriteLine($"index of 'test' after character 44 :  { resultInt}");
            Console.WriteLine();

            resultInt = testString.LastIndexOf("test");
            Console.WriteLine($"Last index of 'test' { resultInt}");

            resultInt = testString.LastIndexOf("test", 44);
            Console.WriteLine($"Last index of 'test' { resultInt}");

            resultInt = testString.LastIndexOf("test", 55);
            Console.WriteLine($"Last index of 'test' { resultInt}");
        }
        private static void OrderingString()
        {
            ComparetoHelper("Mary", "Bob");
            ComparetoHelper("Mary", null);
            ComparetoHelper("Adam", "Bob");
            ComparetoHelper("Bob", "Bob");
            ComparetoHelper("Bob", "Bobby");

            Console.WriteLine();

            CompareHelper("Mary", "Bob");
            CompareHelper("Mary", null);
            CompareHelper(null, "Bob");
            CompareHelper("Bob", "Bob");
            CompareHelper("Bob", "Bobby");
            CompareHelper(null, null);
        }
        private static void ComparetoHelper(string testA, string? testB)
        {
            int resultint = testA.CompareTo(testB);
            switch (resultint)
            {
                case > 0:
                    Console.WriteLine($"Compare to : {testB ?? "null"} comes before {testA}");
                    break;


                case < 0:
                    Console.WriteLine($"Compare to : {testA} comes After {testB}");
                    break;

                case 0:
                    Console.WriteLine($"Compare to : {testA} is the same as {testB}");
                    break;

            }
        }
        private static void CompareHelper(string? testA, string? testB)
        {
            int resultint = String.Compare(testA, testB);
            switch (resultint)
            {
                case > 0:
                    Console.WriteLine($"Compare : {testB ?? "null"} comes before {testA ?? "null"}");
                    break;


                case < 0:
                    Console.WriteLine($"Compare : {testA ?? "null"} comes After {testB ?? "null"}");
                    break;

                case 0:
                    Console.WriteLine($"Compare : {testA ?? "null"} is the same as {testB ?? "null"}");
                    break;

            }
        }
        private static void EqualtoHelper()
        {
            EqualityHelper("Bob", "Mary");
            EqualityHelper(null, "");
            EqualityHelper("", " ");
            EqualityHelper("Bob", "Mary");
            EqualityHelper("Bob", "bob");
        }
        private static void EqualityHelper(string? testA, string? testb)
        {
            bool resultBoolean;

            resultBoolean = String.Equals(testA, testb);
            if (resultBoolean)
            {
                Console.WriteLine($"Equals : '{testA ?? "null"}' Equals '{testb ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals : '{testA ?? "null"}' Not Equals '{testb ?? "null"}'");
            }

            Console.WriteLine();
            // Ignor string case
            resultBoolean = String.Equals(testA, testb, StringComparison.InvariantCultureIgnoreCase);
            if (resultBoolean)
            {
                Console.WriteLine($"Equals :(ignore case) '{testA ?? "null"}' Equals '{testb ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals : (ignor case)'{testA ?? "null"}' Not Equals '{testb ?? "null"}'");
            }

            Console.WriteLine();
            // ==
            resultBoolean = testA == testb;
            if (resultBoolean)
            {
                Console.WriteLine($"== : '{testA ?? "null"}' Equals '{testb ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"== : '{testA ?? "null"}' Not Equals '{testb ?? "null"}'");
            }
        }
        private static void GettingASubstring()
        {
            string testString = "this is a test of substring. let's see how it Works.";
            string results;

            results = testString.Substring(5);
            Console.WriteLine(results);

            results = testString.Substring(5, 4);
            Console.WriteLine(results);
        }
        private static void ReplacingText()
        {
            string testString = "this is a test of replace. let's see how it Works.";
            string results;
            results = testString.Replace("test", "trial");
            Console.WriteLine(results);

            results = testString.Replace(" test ", " trial ");
            Console.WriteLine(results);

            results = testString.Replace("Work", "new work", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(results);
        }
        private static void InsertText()
        {
            string testString = "this is a test of replace. let's see how it Works.";
            string results;
            results = testString.Insert(5, "(test) ");
            Console.WriteLine(results);
        }
        private static void RemoveText()
        {
            string testString = "this is a test of replace. let's see how it Works.";
            string results;
            results = testString.Remove(25);
            Console.WriteLine(results);

            results = testString.Remove(25 , 10);
            Console.WriteLine(results);
        }




    }
}
