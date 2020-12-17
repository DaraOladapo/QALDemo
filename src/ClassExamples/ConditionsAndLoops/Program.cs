using System;

namespace ConditionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome my program. What year were you born?");
            //int UserYOB = GetInput();
            //int UserAge = 2020 - UserYOB;
            //if (UserAge < 13)
            //{
            //    Console.WriteLine("Sorry, you are too young to register online");
            //}
            //else if (UserAge >= 13 && UserAge <= 20)
            //{
            //    Console.WriteLine("You qualify for 50% discount");
            //}
            //else if (UserAge > 20)
            //{
            //    Console.WriteLine("Welcome, you are now signed up");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, we couldn't help you");
            //}

            //switch (UserAge)
            //{

            //    case int n when n >= 1 && n < 13:
            //        Console.WriteLine("Sorry, you are too young to register online");
            //        break;
            //    case int n when n >= 13 && n <= 20:
            //        Console.WriteLine("You qualify for 50% discount");
            //        break;
            //    case int n when n > 20:
            //        Console.WriteLine("Welcome, you are now signed up");
            //        break;
            //    default:
            //        Console.WriteLine("Sorry, we couldn't help you");
            //        break;
            //}

            int UserAge = 12;
            //string Message = UserAge <= 13 ? "Too young" : "Verified";
            string Message = UserAge <= 13 ? "Too young" : UserAge == 13 ? "Exact" : "Way high";
            Console.WriteLine(Message);
        }

        static int Counter = 0;
        private static int GetInput()
        {
            int UserYOB;
            string UserInput = Console.ReadLine();
            bool isValidInput = int.TryParse(UserInput, out UserYOB);
            if (!isValidInput)
            {
                Counter++;
                if (Counter == 3)
                {
                    Console.WriteLine("I think we're done here, you had your chance. We gonna quit now. Peace.");
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    UserYOB = GetInput();
                }
            }
            return UserYOB;
        }

    }
}
