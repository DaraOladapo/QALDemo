using ExtensionMethodsLabs.Helpers;
using System;
using System.Collections.Generic;

namespace ExtensionMethodsLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Make="Toyota", Model="CH-R", Year=2020},
                new Car{Make="Nissan", Model="Qashqai", Year=2019},
                new Car{Make="Vauxhaul", Model="Astra", Year=2018},
                new Car{Make="Toyota", Model="Corolla", Year=2005},
                new Car{Make="Ford", Model="Focus", Year=2000}
            };
            var carMakesList = cars.GetSortedMakes();
            foreach (string carMake in carMakesList)
            {
                Console.WriteLine(carMake);
            }
        }
    }
}
