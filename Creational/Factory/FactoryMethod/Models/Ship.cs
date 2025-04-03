using Creational.Factory.FactoryMethod.Interfaces;

namespace Creational.Factory.FactoryMethod.Models
{
    internal class Ship : ITransport
    {
        public string Deliver()
        {
            return "The delivery is by ship. It will take a total of 5 days.";
        }
    }
}
