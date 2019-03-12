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
            //int counter = 1;
            //string[] names = new string[] {"Viktor", "Petar", "Dario"};

            //Console.WriteLine("Enter your name: ");
            //string input = Console.ReadLine();
            //int index = names.Length;
            //names[index + 1] = input;
            //names = names.Concat(new string[2] ).ToArray();
            //foreach (string name in names)
            //{
            //Console.WriteLine(name); 
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //Console.WriteLine(names[i], string.Concat(input));

            //}

            //Array.Resize(ref names, counter);


            //int index = 0;
            //string[] names = new string[1000];
            //names[index] = "Viktor";
            //index++;
            //names[index] = "Petar";


            //Console.WriteLine("Enter new name: ");
            //string input = Console.ReadLine();

            //index++;
            //names[index] = input;

            //for(int i = 0; i < names.Length; i++)
            //{
            //  Console.WriteLine(names[i]);
            //}





            int index = 2;
            string[] names = new string[] { "Viktor", "Petar", "Dario" };
            string input = "";

            Console.WriteLine("Enter new name: ");
            input = Console.ReadLine();
            for(int y = 0; y < names.Length; y++)
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
