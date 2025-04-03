using Creational.Factory.FactoryMethod.Interfaces;

namespace Creational.Factory.FactoryMethod.Models
{
    internal class Truck : ITransport
    {
        public string Deliver()
        {
            return "The delivery is by truck. It will take a total of 3 days.";
        }
    }
}
