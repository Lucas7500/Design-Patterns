using Creational.Factory.SimpleFactory.Interfaces;

namespace Creational.Factory.SimpleFactory.Models
{
    internal class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push notification sent with message: {message}");
        }
    }
}
