using System;

namespace CarsRevisited
{
    class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int WheelSize { get; set; }
        public Vehicle(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public void Start()
        {
            Console.WriteLine("Started...");
        }
        public void Stop()
        {
            Console.WriteLine("Stopped...");
        }
    }
}
