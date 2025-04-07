namespace Structural.Bridge.CharacterExample
{
    /// <summary>
    /// Abstraction
    /// </summary>
    /// <param name="interactionBehaviour"></param>
    internal abstract class Character(IInteractionBehaviour interactionBehaviour)
    {
        public abstract void Move();

        public virtual void Interact()
        {
            interactionBehaviour.Interact();
        }
    }
}
