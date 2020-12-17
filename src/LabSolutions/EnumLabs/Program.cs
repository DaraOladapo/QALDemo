using System;

namespace EnumLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Monthie();

            Console.WriteLine("Please input your date of birth (format is DD/MM/YYYY) e.g. 28/6/1999)");
            var UserInput = string.Format(Console.ReadLine(), "DD/MM/YYYY");
            var UserInputDateTime = (MonthsOfTheYear)DateTime.Parse(UserInput).Month;
            switch (UserInputDateTime)
            {
                case MonthsOfTheYear.January:
                    
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.January} has 31 days");
                    break;
                case MonthsOfTheYear.February:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.February} has 28/29 days");
                    break;
                case MonthsOfTheYear.March:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.March} has 31 days");
                    break;
                case MonthsOfTheYear.April:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.April} has 30 days");
                    break;
                case MonthsOfTheYear.May:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.May} has 31 days");
                    break;
                case MonthsOfTheYear.June:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.June} has 30 days");
                    break;
                case MonthsOfTheYear.July:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.July} has 31 days");
                    break;
                case MonthsOfTheYear.August:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.August} has 31 days");
                    break;
                case MonthsOfTheYear.September:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.September} has 30 days");
                    break;
                case MonthsOfTheYear.October:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.October} has 31 days");
                    break;
                case MonthsOfTheYear.November:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.November} has 30 days");
                    break;
                case MonthsOfTheYear.December:
                    Console.WriteLine($"Your month of birth - {MonthsOfTheYear.December} has 31 days");
                    break;
            }

        }
        static void Monthie()
        {
            Console.WriteLine($"1. {MonthsOfTheYear.January} has 31 days");
            Console.WriteLine($"2. {MonthsOfTheYear.February} has 28/29 days");
            Console.WriteLine($"3. {MonthsOfTheYear.March} has 31 days");
            Console.WriteLine($"4. {MonthsOfTheYear.April} has 30 days");
            Console.WriteLine($"5. {MonthsOfTheYear.May} has 31 days");
            Console.WriteLine($"6. {MonthsOfTheYear.June} has 30 days");
            Console.WriteLine($"7. {MonthsOfTheYear.July} has 31 days");
            Console.WriteLine($"8. {MonthsOfTheYear.August} has 31 days");
            Console.WriteLine($"9. {MonthsOfTheYear.September} has 30 days");
            Console.WriteLine($"10. {MonthsOfTheYear.October} has 31 days");
            Console.WriteLine($"11. {MonthsOfTheYear.November} has 30 days");
            Console.WriteLine($"12. {MonthsOfTheYear.December} has 31 days");
        }
    }
    enum MonthsOfTheYear
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
