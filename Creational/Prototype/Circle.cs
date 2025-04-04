using Creational.Prototype.Interfaces;

namespace Creational.Prototype
{
    internal class Circle(int radius) : IShape
    {
        public int Radius { get; set; } = radius;

        public IShape Clone() => new Circle(Radius);

        public void Display()
        {
            Console.WriteLine($"Circle with radius: {Radius}");
        }
    }
}
