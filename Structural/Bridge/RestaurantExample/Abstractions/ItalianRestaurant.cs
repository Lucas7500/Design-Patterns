using Structural.Bridge.RestaurantExample;

namespace Structural.Bridge.RestaurantExample.Abstractions
{
    internal class ItalianRestaurant(Pizza pizza) : Restaurant(pizza)
    {
        private readonly Pizza _pizza = pizza;

        protected override void MakeCrust()
        {
            _pizza.Crust = "Thin";
        }

        protected override void AddSauce()
        {
            _pizza.Sauce = "Oil";
        }

        protected override void AddToppings()
        {
            _pizza.Toppings = "";
        }
    }
}
