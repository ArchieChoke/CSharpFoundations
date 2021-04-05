using InheritanceMiniProject.Interfaces;
using System;

namespace InheritanceMiniProject.Models
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.Write($"This {ProductName} book has been purhased.");
        }

        public void ReturnPurchase()
        {
            QuantityInStock += 1;
            Console.Write($"This {ProductName} book has been returned.");
        }
    }
}
