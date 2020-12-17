using System;

namespace CarsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, what's the weather today?");
            int WeatherToday = int.Parse(Console.ReadLine());
            Weather myWeather = new Weather { TempInDegC = WeatherToday };
            Console.WriteLine($"DegC: {myWeather.TempInDegC}\nDegF: {myWeather.TempInDegF}");

            Vehicle myVehicle = new Vehicle(2020, "Toyota", "CH-R");// { WheelSize=19};
            Console.WriteLine($"{myVehicle.Make} {myVehicle.Model} {myVehicle.Year}");

            Vehicle myOtherVehichle = new Vehicle(make: "Ford", model: "Focus", year: 2019);
        }
    }
}
