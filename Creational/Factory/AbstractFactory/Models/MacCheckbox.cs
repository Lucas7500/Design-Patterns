using Creational.Factory.AbstractFactory.Interfaces;

namespace Creational.Factory.AbstractFactory.Models
{
    internal class MacCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Mac Checkbox";
        }
    }
}
