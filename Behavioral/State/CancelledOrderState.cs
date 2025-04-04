using Behavioral.State.Interfaces;
using Behavioral.State.Models;

namespace Behavioral.State
{
    internal class CancelledOrderState : IOrderState
    {
        public void Process(Order order)
        {
            order.State = new ProcessedOrderState();
        }

        public void Ship(Order order)
        {
            throw new InvalidOperationException("Order is cancelled and cannot be shipped.");
        }

        public void Deliver(Order order)
        {
            throw new InvalidOperationException("Order is cancelled and cannot be delivered.");
        }

        public void Cancel(Order order)
        {
            throw new InvalidOperationException("Order is cancelled and cannot be cancelled again.");
        }
    }
}
