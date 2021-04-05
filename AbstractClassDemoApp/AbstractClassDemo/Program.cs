using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new Book();
            item.ProductName = "Huh?";

            List<IVehicle> Ivehicle = new List<IVehicle>();
            List<ICarExtras> Icar = new List<ICarExtras>();
            Car car = new Car();
           
            car.VIN = "11A-W86S-12A";
            car.Model = "Snitch 3000";
            car.YearManufactured = 1980;
            car.Manufacturer = "Your mom";
            car.NumberOfSpareWheels = 1;
            car.NumberOfSpareWheels = 20;

            Ivehicle.Add(car);
            Icar.Add(car);

            foreach (var ivehicle in Ivehicle)
            {
                ivehicle.PrintVechicleDetails();
            }

            foreach (var icars in Icar)
            {
                icars.PrintVechicleDetails();
                icars.PrintExtras();
            }


            Console.ReadLine();
        }
    }

    public interface IVehicle
    {
        void PrintVechicleDetails();
    }

    public interface ICarExtras: IVehicle
    {
        void PrintExtras();
    }

    public abstract class Vehicle: IVehicle
    {
        public string VIN { get; set; }
        public string  Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
        public void PrintVechicleDetails()
        {
            Console.WriteLine($"Vehicle VIN: {VIN}");
            Console.WriteLine($"Vehicle Manufacturer: {Manufacturer}");
            Console.WriteLine($"Vehicle Model: {Model}");
            Console.WriteLine($"Vehicle YearManufactured: {YearManufactured}");
        }
    }

    public class Car : Vehicle, ICarExtras
    {
        public int NumberOfWheels { get; set; }

        public int NumberOfSpareWheels { get; set; }

        public void PrintExtras()
        {
            Console.WriteLine($"Car NumberOfWheels: {NumberOfWheels}");
            Console.WriteLine($"Car NumberOfSpareWheels: {NumberOfSpareWheels}");
        }

    }

}
