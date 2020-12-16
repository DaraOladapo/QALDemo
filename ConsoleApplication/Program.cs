using HttpClientServiceHelper;
using System;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var HttpStringResponse =  HttpClientHelper.GetAsStringAsync("https://my.api.mockaroo.com/employees.json?key=9a55a0e0");
            Console.WriteLine(HttpStringResponse.Result);
        }

    }
}
