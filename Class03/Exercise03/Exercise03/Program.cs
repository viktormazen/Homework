using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 2
            //Create an array of integers with length of 20 and fill the array from user's input.
            //Task 3
            //Print all numbers of the array, in case a number is 0 it should print "Skipped" 
            //and in case a number is a 3 - digit number it should stop the printing.

            int[] numbers = new int[20];
            Console.WriteLine("Please enter a twenty numbers");
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("");
            foreach (int number in numbers)
            {
                if(number == 0)
                {
                    continue;
                }
                if (number >= 100)
                {
                    break;
                }
                
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
