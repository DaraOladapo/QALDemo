using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string intString = "55";
            string doubleString = "55.5";

            int myInt = int.Parse(intString);
            Console.WriteLine(myInt);

            double mydouble = double.Parse(doubleString);
            Console.WriteLine(mydouble);

            //try Parse
            string badIntString = "Dara";
            string goodIntString = "55";

            //problematic
            //int badInt = int.Parse(badIntString);
            //Console.WriteLine(badInt);
            int parsedInt;
            bool isGoodOutput = int.TryParse(badIntString, out parsedInt);
            if (isGoodOutput)
                Console.WriteLine(parsedInt);
            else
                Console.WriteLine("Very bad output");

            //works just fine
            int goodInt = int.Parse(goodIntString);
            Console.WriteLine(goodInt);
        }
    }
}
