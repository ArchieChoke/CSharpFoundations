namespace InheritanceMiniProject.Interfaces
{
    public interface IPurchasable: IInventoryItem
    {
        void Purchase();

        void ReturnPurchase();

    }
}
