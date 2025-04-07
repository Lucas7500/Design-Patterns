namespace Structural.Bridge.CharacterExample.Implementors
{
    internal class TradeBehaviour : IInteractionBehaviour
    {
        public void Interact()
        {
            Console.WriteLine("Trading with the player!");
        }
    }
}
