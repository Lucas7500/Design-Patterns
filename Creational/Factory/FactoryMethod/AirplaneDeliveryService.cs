using Creational.Factory.FactoryMethod.Abstraction;
using Creational.Factory.FactoryMethod.Interfaces;
using Creational.Factory.FactoryMethod.Models;

namespace Creational.Factory.FactoryMethod
{
    internal class AirplaneDeliveryService : TransportCompany
    {
        protected override ITransport CreateTransport() => new Airplane();
    }
}
