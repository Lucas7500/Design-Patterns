using Behavioral.State.Interfaces;
using Behavioral.State.Models;

namespace Behavioral.State
{
    internal class DeliveredOrderState : IOrderState
    {
        public void Process(Order order)
        {
            throw new InvalidOperationException("Order is already delivered and cannot be processed again.");
        }

        public void Ship(Order order)
        {
            throw new InvalidOperationException("Order is already delivered and cannot be shipped again.");
        }

        public void Deliver(Order order)
        {
            throw new InvalidOperationException("Order is already delivered and cannot be delivered again.");
        }

        public void Cancel(Order order)
        {
            throw new InvalidOperationException("Order is already delivered and cannot be cancelled.");
        }
    }
}
