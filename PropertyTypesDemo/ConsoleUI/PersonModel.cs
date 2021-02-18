using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public PersonModel(string firstName)
        {
            FirstName = firstName;

        }
        public PersonModel(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public PersonModel(string firstName, string lastName, int age,string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }
        public PersonModel(string firstName, string lastName, int age, string ssn, string streetAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
            StreetAddress = streetAddress;
        }
        public PersonModel(string firstName, string lastName, int age, string ssn, string streetAddress,string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
            StreetAddress = streetAddress;
            City = city;
        }
        public PersonModel(string firstName, string lastName, int age, string ssn, string streetAddress, string city,string stateProvince)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
        }
        public PersonModel(string firstName, string lastName, int age, string ssn, string streetAddress, string city, string stateProvince, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
            ZipCode = zipCode;
        }
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range of 1 - 126");
                }
                _age = value;
            }
        }
        //public string SSN { get; set; } //Social Security Number 345-13-1234
        private string _ssn;
        public string SSN
        {
            get
            {
                // 345-13-1234
                string output = "***-**-**-****" + _ssn.Substring(_ssn.Length - 5);
                return output;
            }
            set
            {
                _ssn = value;
            }
        }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }

        private string _zipCode;
        public string ZipCode
        {
            get {
                return _zipCode; 
            }
            set { 
                if(Convert.ToInt32(value) > 1)
                {
                    if (value.Count() < 3)
                    {
                        throw new ArgumentOutOfRangeException("value", "Zipcode entered is out of range");
                    }
                    else 
                    { 
                        _zipCode = value; 
                    }
                }
                
            }
        }
        public string FullAddress
        {
            get 
            { 
                return ($"StreetAddress: { StreetAddress } | " +
                        $"City: { City } | " +
                        $"State / Province : { StateProvince } | " +
                        $"ZipCode: { ZipCode } | " ); 
            }
            
        }

    }
}
