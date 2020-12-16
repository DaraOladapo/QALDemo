using System;

namespace Interafaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2020, "Ford", "Focus", 4);
            myCar.Start();
            myCar.Stop();
            myCar.Drive();
            myCar.Drive("Manchester");
        }
    }
    interface IDrivable
    {
        void Drive();
        void Drive(string Location);
    }
    class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
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
    //abstract class Car : Vehicle
    class Car : Vehicle, IDrivable
    {
        public Car(int year, string make, string model, int numberofTyres) : base(year, make, model)
        {
            NumberOfTyres = numberofTyres;
        }
        public int NumberOfTyres { get; set; }

        public void Drive()
        {
            Console.WriteLine("Car is driving..");
        }

        public void Drive(string Location)
        {
            Console.WriteLine($"Car is driving to {Location}..");
        }

        new public void Start()
        {
            Console.WriteLine("Car has started...");
        }
        public override string ToString()
        {
            return $"{Make} {Model} {Year}";
        }
    }
}
