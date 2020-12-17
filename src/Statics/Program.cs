using System;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            //static
            //Console.WriteLine(Utility.isStaticGoodDay);
            string emailAddress = "me@daraoladapo.com", badEmailAddress = "me:@m.@@";
            var isThisEmailValid = Utility.IsEmailValid(emailAddress);
            Console.WriteLine($"{emailAddress} valid?: {isThisEmailValid}");

            isThisEmailValid = Utility.IsEmailValid(badEmailAddress);
            Console.WriteLine($"{badEmailAddress} valid?: {isThisEmailValid}");

            //not static
            //var isGoodDay = new Utility().isGoodDay;
            //Console.WriteLine(isGoodDay);
        }
    }
    class Utility
    {
        public bool isGoodDay = true;
        public static bool isStaticGoodDay = true;

        public static bool IsEmailValid(string EmailAddress)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(EmailAddress);
                return addr.Address == EmailAddress;
            }
            catch
            {
                return false;
            }
        }
    }
}
