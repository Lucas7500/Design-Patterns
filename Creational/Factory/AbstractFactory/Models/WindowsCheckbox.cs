using Creational.Factory.AbstractFactory.Interfaces;

namespace Creational.Factory.AbstractFactory.Models
{
    internal class WindowsCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Windows Checkbox";
        }
    }
}
