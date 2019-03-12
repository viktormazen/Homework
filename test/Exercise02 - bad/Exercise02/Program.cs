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

            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array and print all the names
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N


            int index = 2;
            string[] names = new string[] { "Viktor", "Petar", "Dario" };
            string input = "";

            Console.WriteLine("Enter new name: ");
            input = Console.ReadLine();
            for (int y = 0; y < names.Length; y++)
            {
                index++;

                if (index >= names.Length)
                {
                    System.Array.Resize(ref names, names.Length + 1);
                }

                names[index] = input;

                Console.WriteLine("");
                Console.WriteLine("- You enter new name, this are all names entered: ");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.WriteLine("Do you want to enter another name(Y / N)?");
                input = Console.ReadLine();



                if (input == "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Enter new name: ");
                    input = Console.ReadLine();
                }
                else if (input == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input please put yes or no !!!");
                    input = Console.ReadLine();
                }

            }
        }
    }
}
