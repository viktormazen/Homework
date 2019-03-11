using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print the date that is 3 days from now
            //Print the date that is one month from now
            //Print the date that is one month and 3 days from now
            //Print 1 year and 2 months ago from today
            //Print only the current month with words
            //Print only the current year

            DateTime dateThreeDays = DateTime.Now.AddDays(3);
            Console.WriteLine(dateThreeDays);
            DateTime dateOneMonth = DateTime.Now.AddMonths(1);
            Console.WriteLine(dateOneMonth);
            DateTime dateOneMonthAndThreeDays = DateTime.Now.AddMonths(1).AddDays(3);
            Console.WriteLine(dateOneMonthAndThreeDays);
            DateTime dateOneYearAndTwoMonths = DateTime.Now.AddYears(1).AddMonths(2);
            Console.WriteLine(dateOneYearAndTwoMonths);
            string currentMonth = DateTime.Now.ToString("MMMM");
            Console.WriteLine(currentMonth);
            string currentYear = DateTime.Now.ToString("yyyy");
            Console.WriteLine(currentYear);


            Console.ReadLine();
        }
    }
}
