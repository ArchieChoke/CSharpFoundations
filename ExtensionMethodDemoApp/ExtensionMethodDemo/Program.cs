using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel room = new HotelRoomModel();
            Person person = new Person();
            room.TurnOnAir().SetTemperature(72).OpenShades();

            room.TurnOffAir().CloseShades();

            person.SetDefaultAge().SetFirstName("Tiago").SetLastName("Culverwell").PrintInfo();
            person.SetAge(34).PrintInfo();

            "Hello world".PrintToConsole();
            Console.ReadLine();
        }        

    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public static class ExtensionPerson
    {
        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 22;
            return person;
        }

        public static Person SetAge(this Person person, int age)
        {
            person.Age = age;
            return person;
        }
        public static Person SetFirstName(this Person person, string firstName)
        {
            person.FirstName = firstName;
            return person;
        }

        public static Person SetLastName(this Person person, string lastName)
        {
            person.LastName = lastName;
            return person;
        }

        public static Person PrintInfo(this Person person)
        {
            Console.WriteLine($"Print info for {person.FirstName},{person.LastName} age: {person.Age}");
            return person;
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }

    public static class ExtensionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room,int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }
        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
