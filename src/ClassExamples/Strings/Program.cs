using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "A pretty nice ", myOtherString = "day.";
            Console.WriteLine(myString + myOtherString);
            Console.WriteLine("{0}{1}", myString, myOtherString);
            Console.WriteLine($"{myString}{myOtherString}");
            Console.WriteLine("This continues on a \nnew line and this on a \ttab. I am quoting myself here saying that \"Today is a good day.\"");
            string CodeLocationOnPC = @"C:\Users\Dara\source\Repos\QALDemo\src\ClassExamples";
            Console.WriteLine($"Code location on \n{CodeLocationOnPC}\tnew tab");

            string myCombinedString = myString + myOtherString;
            string replacedString = myCombinedString.Replace("day","week");
            Console.WriteLine(replacedString);
            Console.WriteLine(myCombinedString);
            Console.WriteLine(myCombinedString.Length);
            foreach (var character in myCombinedString)
            {
                Console.WriteLine(character);
            }
            string myRealString = myString;
            Console.WriteLine(myRealString);
            myString = "Hey hey";
            Console.WriteLine(myRealString);
        }
    }
}
