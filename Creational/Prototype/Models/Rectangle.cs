using Creational.Prototype.Interfaces;

namespace Creational.Prototype.Models
{
    internal class Rectangle(int width, int height) : IShape
    {
        public int Width { get; set; } = width;
        public int Height { get; set; } = height;

        public IShape Clone() => new Rectangle(Width, Height);

        public void Display()
        {
            Console.WriteLine($"Rectangle with width: {Width}, height: {Height}");
        }
    }
}
