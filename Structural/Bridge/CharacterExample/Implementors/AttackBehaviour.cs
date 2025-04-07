namespace Structural.Bridge.CharacterExample.Implementors
{
    internal class AttackBehaviour : IInteractionBehaviour
    {
        public void Interact()
        {
            Console.WriteLine("Attacking the player!");
        }
    }
}
