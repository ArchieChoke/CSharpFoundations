using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { ProductName = "Kia Optima", QuantityInStock = 2, DealerFee = 350 };
            var book = new BookModel { ProductName = "A Tale of two Cities", QuantityInStock = 2, NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "CAT - D98 75", QuantityInStock = 2 , DeliveryFee = 1200 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.WriteLine("Do you want to rent or purchase something: (rent,purchase)");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine($"Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if(wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.WriteLine($"Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine($"Do you want to purchase this product (yes/no): ");

                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }

                    Console.WriteLine($"Do you want to return your product (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnPurchase();
                    }
                }
            }

            //inventory.Add(new VehicleModel { ProductName = "Kia Optima", DealerFee = 25 });
            //inventory.Add(new BookModel {  ProductName = "Kia Optima", NumberOfPages = 350 });

            Console.ReadLine();
        }
    }
}
