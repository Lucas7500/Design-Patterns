using Structural.Adapter.Interfaces;
using Structural.Adapter.Models;
using System.Text.Json;

namespace Structural.Adapter
{
    internal class ResourceToJsonAdapter : IResourceAdapter
    {
        public string Generate(string resourceName)
        {
            return JsonSerializer.Serialize(new Resource(resourceName, "This is a resource in JSON format"));
        }
    }
}
