﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();

            intList.Add(1);
            string result = FizzBuzz<string>("tests");
            Console.WriteLine($"Tests: { result } ");

            result = FizzBuzz(123);
            Console.WriteLine($"123: { result } ");

            result = FizzBuzz(true);
            Console.WriteLine($"true: { result } ");

            result = FizzBuzz(new PersonModel { FirstName = "Tiago", LastName = "Culverwell" });
            Console.WriteLine($"Person: { result } ");


            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tiago", LastName = "Culverwell" });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected. ");
            }

        }

        // 3 - Fizz, 5 - Buzz, 3 & 5 - FizzBuzz
        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";
            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }
                        
            return output;
        }
    }

    public class GenericHelper<T> where T: IErrorCheck, new() //Empty constructor
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();
        public void CheckItemAndAdd(T item)
        {
            if(item.HasError == false)
            {
                Items.Add(item);
            }else
            {
                RejectedItems.Add(item);
            }
            //T test = new T();
            
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearMaufactured { get; set; }
        public bool HasError { get; set; }
    }

    public class PersonModel: IErrorCheck
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public bool HasError { get; set; }
    }
}
