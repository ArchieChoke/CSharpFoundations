using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new SmartPhone());


            foreach (var phone in phones)
            {
                phone.PlaceCall();
            }


            Console.ReadLine();
        }

        public class Vehicle
        {
            public void Accelerate()
            {

            }

            public void Stop()
            { 

            }
        }

        public class Boat : Vehicle
        {

        }

        public class Motor : Vehicle
        {

        }

        public class Car : Vehicle
        {

        }

        // Create vehicle class 
        // A Car Class 
        // A Boat Class
        // A Motor Cycle Class
    }
}
