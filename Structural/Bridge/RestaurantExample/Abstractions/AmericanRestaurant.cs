using Structural.Bridge.RestaurantExample;

namespace Structural.Bridge.RestaurantExample.Abstractions
{
    internal class AmericanRestaurant(Pizza pizza) : Restaurant(pizza)
    {
        private readonly Pizza _pizza = pizza;

        protected override void MakeCrust()
        {
            _pizza.Crust = "Thick";
        }

        protected override void AddSauce()
        {
            _pizza.Sauce = "Super Secret Recipe";
        }

        protected override void AddToppings()
        {
            _pizza.Toppings = "Everything";
        }
    }
}
