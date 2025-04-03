using Creational.Factory.AbstractFactory.Interfaces;

namespace Creational.Factory.AbstractFactory.Models
{
    internal class MacButton : IButton
    {
        public string Render()
        {
            return "Mac button";
        }
    }
}
