using System;

namespace CarsRevisited
{
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
}
