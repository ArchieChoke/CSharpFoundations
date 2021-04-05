using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel();
            person.Firstname = "Archie";
            person.LastName = "Choke";

            Console.ReadLine();
        }
    }
}
