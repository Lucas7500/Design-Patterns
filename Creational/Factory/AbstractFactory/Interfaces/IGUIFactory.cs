namespace Creational.Factory.AbstractFactory.Interfaces
{
    internal interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
