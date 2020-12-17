using System;

namespace Loopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = { 34, 343, 343, 54 };
            //foreach (var myInt in myInts)
            //{
            //    Console.WriteLine(myInt);
            //}
            //for (int i = 0; i < myInts.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {myInts[i]}");
            //}
            //while loop
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("now to do while loop");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}
