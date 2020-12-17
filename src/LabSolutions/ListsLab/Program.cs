using System;
using System.Collections.Generic;

namespace ListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many inputs do you want to make?");
            int NumberOfInputs = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 1; i <= NumberOfInputs; i++)
            {
                Console.WriteLine("Make: ");
                string MakeInput = Console.ReadLine();
                Console.WriteLine("Model: ");
                string ModelInput = Console.ReadLine();
                Console.WriteLine("Year of Manufacture: ");
                int YearOfManufactureinput = int.Parse(Console.ReadLine());
                var carToAdd = new Car
                {
                    Make = MakeInput,
                    Model = ModelInput,
                    YearOfManufacture = YearOfManufactureinput
                };
                cars.Add(carToAdd);
            }
        }
    }
}
