using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today

            Console.WriteLine("Enter a year of birth(YYYY):");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a month of birth(MM):");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a day of birth(DD):");
            int day = int.Parse(Console.ReadLine());
            var bla = new DateTime(year, month, day);
            Console.WriteLine($"You are {AgeCalculator(bla)} years old");


            Console.ReadLine();
        }
        private static int AgeCalculator(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if(DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
