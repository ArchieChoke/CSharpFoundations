using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models
{
    //Purchases and Rentals
    public class InventoryItemModel : IInventoryItem
    {
        //Things about the 
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
}
