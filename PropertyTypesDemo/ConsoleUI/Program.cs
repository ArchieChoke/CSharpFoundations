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
            List<PersonModel> person = new List<PersonModel>();
            person.Add(new PersonModel("Tiago"
                                        , "Culverwell"
                                        , 34
                                        , "345-13-1234"
                                        , "22 Osler Street Rynfield Benoni"
                                        , "Johanessburg"
                                        , "Gauteng"
                                        , "1501"));

            person.Add(new PersonModel("Joe"
                                        , "Smith"
                                        , 34
                                        , "345-12-1214"
                                        , "23 Osler Street Rynfield Benoni"
                                        , "Johanessburg"
                                        , "Gauteng"
                                        , "1501"));


            foreach(PersonModel p in person)
            {
                Console.WriteLine($" Firstname: { p.FirstName } | Lastname: {p.LastName} | Age: { p.Age }");
                Console.WriteLine($" Full Address { p.FullAddress } ");                
            }
            
            Console.ReadLine();
        }
    }
}
