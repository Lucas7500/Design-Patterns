using Creational.Factory.FactoryMethod.Interfaces;

namespace Creational.Factory.FactoryMethod.Models
{
    internal class Airplane : ITransport
    {
        public string Deliver()
        {
            return "The delivery is by airplane. It will take a total of 15 hours.";
        }
    }
}
