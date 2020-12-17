using System;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2020, "Ford", "Focus", 4);
            myCar.Start();
            myCar.Stop();
            Console.WriteLine(myCar.ToString());

            //object myCarCast = new Car(2020, "Ford", "Focus", 4);
            //var myCarObject = myCarCast as Car;
            //myCarObject.Start();
            //myCarObject.Stop();

            //Vehicle vehicle = new Vehicle(2020, "Ford", "Focus");
            //if (myCar is Vehicle)
            //{
            //    Console.WriteLine("Car is  of type vehicle");
            //}
            //else
            //{
            //    Console.WriteLine("Car is not of type vehicle");
            //}
            //Weather today = new Weather() { TempInDegC = 8 };
            //Console.WriteLine($"Temp in Deg C: {today.TempInDegC}\nTemp in Deg F: {today.TempInDegF}");
        }
    }
    class AbstractedClass
    {
        static int myInt = 5;
        static private int myPrivateInt = 50;
        static public int myPublicInt = 500;
        static internal int myInternalInt = 5000;
    }
    //sealed class Vehicle
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
    class Car : Vehicle
    {
        public Car(int year, string make, string model, int numberofTyres) : base(year, make, model)
        {
            NumberOfTyres = numberofTyres;
        }
        public int NumberOfTyres { get; set; }
        new public void Start()
        {
            Console.WriteLine("Car has started...");
        }
        public override string ToString()
        {
            return $"{Make} {Model} {Year}";
        }
    }
    class Weather
    {
        public double TempInDegC { get; set; }
        public double TempInDegF => TempInDegC * 1.8 + 32;
    }
}
