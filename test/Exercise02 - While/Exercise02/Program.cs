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

            ////foreach (string name in names)
            ////{
            ////Console.WriteLine(name); 
            ////}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}
            //Array.Resize(ref names, counter);

            //Console.ReadLine();



            // odkomentiraj edno ili drugo

            //nacin1();
            nacin2();
        }

        public static void nacin1()
        {
            int indexer = 0;
            string[] names = new string[1000];
            names[indexer] = "Viktor";
            indexer++;
            names[indexer] = "Petar";
            indexer++;
            names[indexer] = "Dario";

            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();

            indexer++;
            names[indexer] = input;


            for (int i = 0; i < indexer; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }

        public static void nacin2()
        {
            int indexer = 2;
            string[] names = new string[] { "Viktor", "Petar", "Dario" };
            string input = "";

            Console.WriteLine("- Enter new name: ");
            input = Console.ReadLine();
            //Console.WriteLine("Do you want to enter another name(Y / N)?");
            while (input != "n")
            {

                indexer++;
                if (indexer >= names.Length)
                {
                    System.Array.Resize(ref names, names.Length + 30);
                }
                names[indexer] = input;

                Console.WriteLine("");
                Console.WriteLine("- You enter new name, this are all names entered: ");
                for (int i = 0; i <= indexer; i++)
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
                 




            }
            
            
        }
    }
}
