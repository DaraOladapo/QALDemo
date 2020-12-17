using System;
using System.Collections.Generic;

namespace DictionaryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> accessCodes = new Dictionary<string, int>();
            accessCodes.Add("HousePassCode", 1234);
            accessCodes.Add("GarageCode", 4321);
            accessCodes.Add("MasterBedroom", 2342);
            accessCodes.Add("MainGate", 4568);
            Console.WriteLine(accessCodes["MasterBedroom"]);
            Console.WriteLine(accessCodes["MainGate"]);
            Console.WriteLine(accessCodes["GarageCode"]);
            Console.WriteLine(accessCodes["HousePassCode"]);
        }
    }
}
