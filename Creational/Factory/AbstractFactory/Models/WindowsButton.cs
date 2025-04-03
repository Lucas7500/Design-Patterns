using Creational.Factory.AbstractFactory.Interfaces;

namespace Creational.Factory.AbstractFactory.Models
{
    internal class WindowsButton : IButton
    {
        public string Render()
        {
            return "Windows Button";
        }
    }
}
