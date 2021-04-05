using InheritanceMiniProject.Interfaces;
using System;

namespace InheritanceMiniProject.Models
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public decimal DeliveryFee { get; set; }
        public void Dig()
        {
            Console.WriteLine("I am diggin. ");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.Write("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.Write("This excavator has been returned. ");
        }
    }
}
