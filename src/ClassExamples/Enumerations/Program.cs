using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var DayOfWeek = (DaysOfTheWeek)DateTime.Today.AddYears(0).DayOfWeek;
            switch (DayOfWeek)
            {
                case DaysOfTheWeek.Sunday:
                case DaysOfTheWeek.Tuesday:
                default:
                    Console.WriteLine("No slogan for today");
                    break;
                case DaysOfTheWeek.Monday:
                    Console.WriteLine("Man Crush Monday");
                    break;
                case DaysOfTheWeek.Wednesday:
                    Console.WriteLine("Woman Crush Wednesday");
                    break;
                case DaysOfTheWeek.Thursday:
                    Console.WriteLine("Throwback Thursday");
                    break;
                case DaysOfTheWeek.Friday:
                    Console.WriteLine("Flashback Friday");
                    break;
                case DaysOfTheWeek.Saturday:
                    Console.WriteLine("Owambe Saturday");
                    break;
            }
        }
    }
    enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
