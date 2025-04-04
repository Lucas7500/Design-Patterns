using Behavioral.State.Models;

namespace Behavioral.State.Interfaces
{
    internal interface IOrderState
    {
        void Process(Order order);
        void Ship(Order order);
        void Deliver(Order order);
        void Cancel(Order order);
    }
}
