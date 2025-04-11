namespace Structural.Facade.Services
{
    internal class Notifier
    {
        public void SendConfirmation(string email)
        {
            Console.WriteLine($"Confirmation sent to email: ${email}");
        }
    }
}
