using System;

namespace InterfacesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car { Make = "Toyota", Model = "CH-R", YearOfManufacture = 2020 };
            myCar.Start();
            myCar.Drive();
            myCar.Stop();
        }
    }
    class Car : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} {YearOfManufacture} is in drive mode");
        }

        public void Start()
        {
            Console.WriteLine($"{Make} {Model} {YearOfManufacture} is in start mode");
        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} {YearOfManufacture} is in stop mode");
        }
    }
    interface ICar
    {
        void Start();
        void Stop();
        void Drive();
    }
}
