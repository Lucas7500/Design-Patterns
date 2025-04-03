using Behavioral.Strategy.Interfaces;

namespace Behavioral.Strategy.Services
{
    internal class ResourceGenerator(IResourceGenerationStrategy resourceAdapter)
    {
        public string Generate(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty!", nameof(name));
            }

            return resourceAdapter.Generate(name);
        }
    }
}
