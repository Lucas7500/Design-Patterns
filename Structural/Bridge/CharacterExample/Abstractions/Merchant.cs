namespace Structural.Bridge.CharacterExample.Abstractions
{
    internal class Merchant(IInteractionBehaviour interactionBehaviour) : Character(interactionBehaviour)
    {
        public override void Move()
        {
            Console.WriteLine("Merchant is moving!");
        }
    }
}
