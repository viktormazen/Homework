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
            //Declare a new array of integers with 5 elements
            //Initialize the array elements with values from input
            //Sum all the values and print the result in the console
            int[] numbers = new int[5];
            Console.WriteLine("Please enter a five numbers");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("Sum for all elements in array is: " + sum);
            

            Console.ReadLine();
        }
    }
}
