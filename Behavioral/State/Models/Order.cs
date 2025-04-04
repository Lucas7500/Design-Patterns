using Behavioral.State.Interfaces;

namespace Behavioral.State.Models
{
    internal class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public required string CustomerName { get; set; }
        public required string Address { get; set; }
        public IOrderState State { get; set; } = new ReceivedOrderState();

        public void Process() => State.Process(this);
        public void Ship() => State.Ship(this);
        public void Deliver() => State.Deliver(this);
        public void Cancel() => State.Cancel(this);
    }
}
