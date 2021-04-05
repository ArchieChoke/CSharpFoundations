using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person
    {
        private string formerLastName = "";

        public string FirstName  { get; private set; }
        public string LastName { get; private set; }
        private string _ssn;
        public string SSN
        {
            get { return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; }
            set { _ssn = value; }
        }

        public void ChangeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void SayHello()
        {
            string test = "hi";
            Console.WriteLine($"Hello {FirstName }");
        }
    }

    
}
