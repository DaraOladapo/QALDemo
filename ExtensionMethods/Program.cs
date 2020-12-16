using ExtensionMethods.Helpers;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailAddress = "me@daraoladapo.com", badEmailAddress = "me:@m.@@";
            var isValidEmail = emailAddress.IsEmailValid();
            Console.WriteLine($"{emailAddress} valid?: {isValidEmail}");

            isValidEmail = badEmailAddress.IsEmailValid();
            Console.WriteLine($"{badEmailAddress} valid?: {isValidEmail}");


            //string ReplaceString = "DaraOladapo";
            //var modifiedString = ReplaceString.Replace("O", "I");
        }
    }
}
