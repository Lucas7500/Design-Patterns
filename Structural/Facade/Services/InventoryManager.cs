namespace Structural.Facade.Services
{
    internal class InventoryManager
    {
        public void UpdateStock(string productId, int quantity)
        {
            Console.WriteLine($"Stock for product {productId} updated by {quantity}");
        }
    }
}
