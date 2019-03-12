using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            string answer;
            do
            {
                Console.WriteLine("Enter a name:");
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = Console.ReadLine();
                Console.WriteLine("Do you want to enter another name ( Y / N)");
                answer = Console.ReadLine();
            }

            while (answer == "Y");

            {
                Console.WriteLine("All names: ");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
