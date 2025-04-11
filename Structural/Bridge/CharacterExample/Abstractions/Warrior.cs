namespace Structural.Bridge.CharacterExample.Abstractions
{
    internal class Warrior(IInteractionBehaviour interactionBehaviour) : Character(interactionBehaviour)
    {
        public override void Move()
        {
            Console.WriteLine("Warrior is moving!");
        }
    }
}
