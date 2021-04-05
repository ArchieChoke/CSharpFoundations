using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
                        
            person.FirstName = "What is your first name: ".RequestString();
            person.FirstName = "What is your last name: ".RequestString();

            Console.WriteLine("What is your age name: ");
            person.Age = int.Parse(Console.ReadLine());



            Console.ReadLine();
        }
    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while(string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
        }



        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;



            while (isValidInt == false || isInValidRange == false)
            {
                Console.WriteLine(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if(useMinMax == true)
                {
                    isInValidRange = (output >= minValue && output <= maxValue);
                    //if(output >= minValue && output <= maxValue)
                    //{
                    //    isInValidRange = true;
                    //}else
                    //{
                    //    isInValidRange = false;
                    //}
                }    
            }

            return output;
        }


    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumberOfChildren { get; set; }
    }
}

