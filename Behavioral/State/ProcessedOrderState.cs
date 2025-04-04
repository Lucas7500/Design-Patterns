using Behavioral.State.Interfaces;
using Behavioral.State.Models;

namespace Behavioral.State
{
    internal class ProcessedOrderState : IOrderState
    {
        public void Process(Order order)
        {
            throw new InvalidOperationException("Order is already being processed and cannot be processed again.");
        }

        public void Ship(Order order)
        {
            order.State = new ShippedOrderState();
        }

        public void Deliver(Order order)
        {
            throw new InvalidOperationException("Order has not been shipped and therefore cannot be delivered");
        }

        public void Cancel(Order order)
        {
            order.State = new CancelledOrderState();
        }
    }
}
