using Creational.Factory.AbstractFactory.Interfaces;
using Creational.Factory.AbstractFactory.Models;

namespace Creational.Factory.AbstractFactory
{
    internal class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
