using System;
using Exercise01.Classes;
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

            Student[] Students = new Student[5];
            Students[0] = new Student("Viktor", "Sedc", "G2");
            Students[1] = new Student("Petar", "Sedc", "G2");
            Students[2] = new Student("Martin", "Sedc", "G2");
            Students[3] = new Student("Dario", "Sedc", "G2");
            Students[4] = new Student("Dragana", "Sedc", "G2");

            Console.WriteLine("Enter a name: ");
            string input = Console.ReadLine();
            FindStudent(input, Students);
            Console.ReadLine();

        }
        static void FindStudent(string name, Student[] Students)
        {

            bool flag = false;

            foreach (var item in Students)
            {
                if (name == item.Name)
                {
                    flag = true;
                    Console.WriteLine($"{item.Name} {item.Academy} {item.Group}"); 
                  
                }
            }
            if (!flag)
            {
                Console.WriteLine("There is not a student whit that name"); 
            }
        }
    }
}
