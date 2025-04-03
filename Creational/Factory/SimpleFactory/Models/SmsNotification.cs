using Creational.Factory.SimpleFactory.Interfaces;

namespace Creational.Factory.SimpleFactory.Models
{
    internal class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS notification sent with message: {message}");
        }
    }
}
