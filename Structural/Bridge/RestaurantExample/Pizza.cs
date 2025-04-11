namespace Structural.Bridge.RestaurantExample
{
    /// <summary>
    /// Implementor
    /// </summary>
    internal abstract class Pizza
    {
        public string Sauce { get; set; } = null!;
        public string Toppings { get; set; } = null!;
        public string Crust { get; set; } = null!;

        public abstract void Assemble();
        public abstract void QualityCheck();
    }
}
