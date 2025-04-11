namespace Structural.Facade.Models
{
    internal record OrderDetails(
        Guid Id,
        string ProductId,
        string Email,
        decimal Amount,
        int Quantity,
        string Address);
}
