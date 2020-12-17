using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQy
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>() {
            new Book{Title="Gullivers Travels", Price=10M, YearPublished= 2015 },
            new Book{Title="War and Peace", Price=20M, YearPublished= 1869 },
            new Book{Title="This is going to hurt", Price=5M, YearPublished= 2017 },
            new Book{Title="Home Alone", Price=2.5M, YearPublished= 1927 }
            };
            /*
             * Manual way: First, declare a list of decimal
             * loop through
             * set a condtion where title contains l
             * add the price field to the list of deciaml
             * loop to print
             */
            var priceQueryResult = books.Where(b => b.Title.Contains("l"))
                .OrderBy(b => b.YearPublished)
                .Select(b => b.Price);

            var querySQLForm = from b in books
                               where b.Title.Contains("l")
                               orderby b.YearPublished
                               select b.Price;

            List<People> people = new List<People>()
            {
                new People{Name="Dara", Balance=30000M},
                new People{Name="Jane", Balance=25300M},
                new People{Name="Ben", Balance=3001M}
            };
            List<Winner> winners = new List<Winner>()
            {
                new Winner { Name="Dara", Award=30000000M},
                new Winner { Name="Jane", Award=25300000M}
            };
            
            var joinLINQQueryResult = people.Join(winners, p => p.Name, w => w.Name, (people, winners) =>
            new { Name = people.Name, Balance = people.Balance, Award = winners.Award });
            
            var joinQuery = from p in people
                            join w in winners
                            on p.Name equals w.Name
                            select new { Name = p.Name, Balance = p.Balance, Award = w.Award };
        }
    }
}
