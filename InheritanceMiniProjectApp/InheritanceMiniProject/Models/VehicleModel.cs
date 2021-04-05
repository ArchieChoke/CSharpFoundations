using InheritanceMiniProject.Interfaces;
using System;

namespace InheritanceMiniProject.Models
{
    public class VehicleModel :InventoryItemModel , IPurchasable,IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.Write($"This {ProductName} has been purhased.");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.Write($"This {ProductName} has been purhased.");
        }

        public void ReturnPurchase() 
        {
            QuantityInStock += 1;
            Console.Write($"This {ProductName} has been  returned from purchase.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.Write($"This {ProductName} has been returned from rental.");
        }
    }
}
