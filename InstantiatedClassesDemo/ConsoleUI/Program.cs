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

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";
            do
            {
                Console.WriteLine("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.WriteLine("What is your last name (or type exit to stop): ");
                lastName= Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.firstName = firstName;
                    person.lastName = lastName;
                    people.Add(person);
                }

            } while (firstName.ToLower() != "exit");


            foreach(PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

        Console.ReadLine();
        }
    }
}
