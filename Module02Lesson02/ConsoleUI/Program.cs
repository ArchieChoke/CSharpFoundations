using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tiago","Culverwell",34,true,"0833264853");

            Console.WriteLine( $"{ person._FirstName} { person._LastName } { person._Age } { person._IsAlive} { person._TelephoneNumber }" );

            Console.ReadLine();
        }

        public class Person
        {
            public string _FirstName { get; set; }
            public string _LastName { get; set; }
            public string _FullName { get; set; }
            public int _Age { get; set; }
            public bool _IsAlive { get; set; }
            public string _TelephoneNumber { get; set; }
            public string getFullName() { return this._FullName = $"{ this._FirstName } { this._LastName }"; }

            public Person(string firstName,string lastName)
            {
                this._FirstName = firstName;
                this._LastName = lastName;
            }
            public Person(string firstName, string lastName,int age)
            {
                this._FirstName = firstName;
                this._LastName = lastName;
                this._Age = age;
            }
            public Person(string firstName, string lastName, int age, bool isAlive)
            {
                this._FirstName = firstName;
                this._LastName = lastName;
                this._Age = age;
                this._IsAlive = isAlive;
            }

            public Person(string firstName, string lastName, int age, bool isAlive, string telephoneNumber)
            {
                this._FirstName = firstName;
                this._LastName = lastName;
                this._Age = age;
                this._IsAlive = isAlive;
                this._TelephoneNumber = telephoneNumber;
            }

        }

        
    }
}
