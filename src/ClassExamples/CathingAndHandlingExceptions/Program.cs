using System;

namespace CathingAndHandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { Make = "Toyota" };
            try
            {
                Console.WriteLine(myCar.Make);
            }
            catch (Exception e)
            {
                //log this error
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Something really bad happened. We cannot proceed.");
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("I will be always be with you");
            }
            Car myBadCar = null;
            try
            {
                Console.WriteLine(myBadCar.Make);
            }
            catch (Exception e)
            {
                //log this error
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Something really bad happened. We cannot proceed.");
            }
            finally
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("I will be always be with you");
            }
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
