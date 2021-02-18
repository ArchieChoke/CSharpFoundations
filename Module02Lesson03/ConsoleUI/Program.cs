using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";

            string lastName = "";

            Console.Write("What is your name: ");
            firstName = (Console.ReadLine().ToString());

            Console.Write("What is your name: ");
            lastName = (Console.ReadLine().ToString());

            if (firstName.ToLower() == "tiago" && firstName.ToLower() == "culverwell")
            {
                Console.WriteLine("Welcome Mr. {0}, {1}", firstName, lastName);
            }
            else if (firstName.ToLower() == "joe")
            {
                Console.WriteLine("Welcome Mr.Joe Smith");
            }
            else
            {
                Console.WriteLine("Welcome Mr. {0}, {1}", firstName, lastName);
            }

            Console.WriteLine("Application done");

            Console.ReadLine();
        }
    }


}
