namespace Structural.Bridge.CharacterExample.Abstractions
{
    internal class Archer(IInteractionBehaviour interactionBehaviour) : Character(interactionBehaviour)
    {
        public override void Move()
        {
            Console.WriteLine("Archer is moving!");
        }
    }
}
