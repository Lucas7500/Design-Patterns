using Structural.Adapter.Interfaces;

namespace Structural.Adapter.Services
{
    internal class ResourceGenerator(IResourceAdapter resourceAdapter)
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
