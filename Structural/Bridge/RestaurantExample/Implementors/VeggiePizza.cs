namespace Structural.Bridge.RestaurantExample.Implementors
{
    internal class VeggiePizza : Pizza
    {
        public override void Assemble()
        {
            Console.WriteLine("Adding Sauce: {0}", Sauce);
            Console.WriteLine("Adding Toppings: {0}", Toppings);
            Console.WriteLine("Adding Cheese");
        }

        public override void QualityCheck()
        {
            Console.WriteLine("Crust is: {0}", Crust);
        }
    }
}
