using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            Console.WriteLine($"{myInt} is of type {myInt.GetType()} with minimum value of {int.MinValue} and maximum value of {int.MaxValue}");
            long myLong = 54245;
            Console.WriteLine($"{myLong} is of type {myLong.GetType()} with minimum value of {long.MinValue} and maximum value of {long.MaxValue}");


            double myDouble = 52.2545;
            Console.WriteLine($"{myDouble} is of type {myDouble.GetType()} with minimum value of {double.MinValue} and maximum value of {double.MaxValue}");
            float myFloat = 5253.25F;
            Console.WriteLine($"{myFloat} is of type {myFloat.GetType()} with minimum value of {float.MinValue} and maximum value of {float.MaxValue}");
            decimal myDecimal = 25.52M;
            Console.WriteLine($"{myDecimal} is of type {myDecimal.GetType()} with minimum value of {decimal.MinValue} and maximum value of {decimal.MaxValue}");

            bool myBool = true;
            Console.WriteLine($"{myBool} is of type {myBool.GetType()} with value either {myBool} or {!myBool}");


            char myChar = 'a';
            Console.WriteLine($"{myChar} is of type {myChar.GetType()} with minimum value of {char.MinValue} and maximum value of {char.MaxValue}");
            string myString = "It's a good day!";
            Console.WriteLine($"{myString} is of type {myString.GetType()}");
        }
    }
}
