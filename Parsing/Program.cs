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
        }
    }
}
