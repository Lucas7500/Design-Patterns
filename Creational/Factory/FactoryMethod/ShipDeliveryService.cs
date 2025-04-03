using Creational.Factory.FactoryMethod.Abstraction;
using Creational.Factory.FactoryMethod.Interfaces;
using Creational.Factory.FactoryMethod.Models;

namespace Creational.Factory.FactoryMethod
{
    internal class ShipDeliveryService : TransportCompany
    {
        protected override ITransport CreateTransport() => new Ship();
    }
}
