using System;
using System.Collections.Generic;

namespace CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Delegates = new List<string>()
        {
            "Becca", "Brendan","Keaton","Mike", "Owen", "Pawel", "Ramya", "Rohan"
        };
            foreach (var myD in Delegates)
            {
                Console.WriteLine($"{Delegates.IndexOf(myD) + 1} {myD}");
            }
        }
        //string FirstStudent = "Becca", SecondStudent = "Brendan", ThirdStudent = "Keaton", FourthStudent = "Mike";

    }
}
