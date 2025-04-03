using Creational.Factory.FactoryMethod.Interfaces;

namespace Creational.Factory.FactoryMethod.Abstraction
{
    internal abstract class TransportCompany
    {
        public string Deliver()
        {
            var transport = CreateTransport();
            return transport.Deliver();
        }
     
        protected abstract ITransport CreateTransport();
    }
}
