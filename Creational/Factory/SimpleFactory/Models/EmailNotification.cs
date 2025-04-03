using Creational.Factory.SimpleFactory.Interfaces;

namespace Creational.Factory.SimpleFactory.Models
{
    internal class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email notification sent with message: {message}");
        }
    }
}
