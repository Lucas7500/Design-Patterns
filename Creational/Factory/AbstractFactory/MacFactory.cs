using Creational.Factory.AbstractFactory.Interfaces;
using Creational.Factory.AbstractFactory.Models;

namespace Creational.Factory.AbstractFactory
{
    internal class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
