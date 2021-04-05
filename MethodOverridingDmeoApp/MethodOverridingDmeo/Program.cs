using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDmeo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Tiago",
                LastName = "Culverwell",
                Email = "tigslc@hotmail.com"
            };

            Console.WriteLine(person.ToString());

            Console.ReadLine();


        }
        public abstract class Car
        {
            public virtual void StartCar()
            {
                Console.WriteLine("Turn key and start");
            }

            public abstract void SetClock(); 
        }
    }
}
