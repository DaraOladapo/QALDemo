using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class Utility
    {
        public static bool IsEmailValid(this string EmailAddress)
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
