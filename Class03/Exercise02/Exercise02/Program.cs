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
            string[] names = new string[] { "Viktor", "Spiro" };
            int index = names.Length - 1;
            string input = "";

            while (true)
            {
                Console.WriteLine("Enter new name: ");
                input = Console.ReadLine();
                index++;
                if(index >= names.Length)
                {
                    System.Array.Resize(ref names, names.Length + 30);
                }
                names[index] = input;
                Console.WriteLine("");
                Console.WriteLine("These are the name you enter so far: ");
                for(int i = 0; i <= index; i++)
                {
                    Console.WriteLine(names[i]);
                }
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do you wnat to enter another name(Y / N)?");
                    input = Console.ReadLine();

                    if(input.ToLower() == "y" || input.ToLower() == "n")
                    {
                        break;
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Invalid input please put yes or no !!!");
                } while (true);

                if(input.ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
