using Behavioral.State.Interfaces;
using Behavioral.State.Models;

namespace Behavioral.State
{
    internal class ReceivedOrderState : IOrderState
    {
        public void Process(Order order)
        {
            order.State = new ProcessedOrderState();
        }

        public void Ship(Order order)
        {
            throw new InvalidOperationException("Order has not been processed and therefore cannot be shipped");
        }
        
        public void Deliver(Order order)
        {
            throw new InvalidOperationException("Order has not been processed and therefore cannot be delivered");
        }

        public void Cancel(Order order)
        {
            order.State = new CancelledOrderState();
        }
    }
}
