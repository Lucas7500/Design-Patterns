using Behavioral.State.Interfaces;
using Behavioral.State.Models;

namespace Behavioral.State
{
    internal class ShippedOrderState : IOrderState
    {
        public void Process(Order order)
        {
            throw new InvalidOperationException("Order is already being shipped and cannot be processed again.");
        }

        public void Ship(Order order)
        {
            throw new InvalidOperationException("Order is already being shipped and cannot be shipped again.");
        }

        public void Deliver(Order order)
        {
            order.State = new DeliveredOrderState();
        }

        public void Cancel(Order order)
        {
            order.State = new CancelledOrderState();
        }
    }
}
