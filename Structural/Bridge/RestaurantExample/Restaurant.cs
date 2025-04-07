namespace Structural.Bridge.RestaurantExample
{
    /// <summary>
    /// Abstraction
    /// </summary>
    /// <param name="pizza"></param>
    internal abstract class Restaurant(Pizza pizza)
    {
        protected abstract void MakeCrust();
        protected abstract void AddSauce();
        protected abstract void AddToppings();

        public void Deliver()
        {
            MakeCrust();
            AddSauce();
            AddToppings();

            pizza.Assemble();
            pizza.QualityCheck();

            Console.WriteLine("Pizza is ready to be delivered.");
        }
    }
}
