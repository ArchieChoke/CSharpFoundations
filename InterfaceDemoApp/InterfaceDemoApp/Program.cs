using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoApp
{
    // Interface is a contract
    // Classes implements interfaces
    // 
    class Program
    {
        static void Main(string[] args)
        {
            doDemonstration();
            HomeWork();
            Console.ReadLine();
        }

        public static void doDemonstration()
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {
                    controller.Connect();
                    controller.CurrentKeyPressed();
                }

                if (controller is IBatteryPowered powered)
                {
                    powered.BatteryLevel = 100;
                }


            }


            using (GameController gc = new GameController())
            {
                gc.Dispose(); //Dispose of the memory space that has been allocated
            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();
            powereds.Add(battery);
            powereds.Add(batteryKeyboard);

        }

        public static void HomeWork()
        {
            List<IRun> runners = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            runners.Add(person);
            runners.Add(animal);

            foreach (IRun run in runners)
            {
                run.Run();
            }
        }

    }

    public interface IRun
    {
        int LegCount { get; set; }
        void Run();
    }

    public class Person: IRun
    {
        public Person()
        {
            LegCount = 2;
        }
        public int LegCount { get; set; }

        public void Run() 
        {
            Console.WriteLine($"The human runs with {LegCount} little legs");
        }

    }

    public class Animal : IRun
    {
        public Animal()
        {
            LegCount = 4;
        }

        public int LegCount { get; set; }

        public void Run()
        {
            Console.WriteLine($"The animal runs with {LegCount} majestic legs");
        }
    }

}
