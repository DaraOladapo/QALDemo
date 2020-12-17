using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Guid> myDictionary = new Dictionary<string, Guid>();
            myDictionary.Add("WindowsPK", Guid.NewGuid());
            myDictionary.Add("OfficePK", Guid.NewGuid());
            myDictionary.Add("VisioPK", Guid.NewGuid());
            myDictionary.Add("VSPK", Guid.NewGuid());
            myDictionary.Add("Project", Guid.NewGuid());

            var VisioPK = myDictionary["VisioPK"];
            Console.WriteLine($"VisioPK: {VisioPK}");

            Dictionary<string, Vehicle> myVehicles = new Dictionary<string, Vehicle>();
            myVehicles.Add("Lambo", new Vehicle { Make = "Lamborghini", Model = "Diablo", Year = 2020, WheelSize = 19 });
            myVehicles.Add("Tyta", new Vehicle { Make = "Toyota", Model = "Corolla", Year = 2019, WheelSize = 17 });
            var myTyta = myVehicles["Tyta"];
            Console.WriteLine($"{myTyta.Make} {myTyta.Model}");
        }
    }
}
