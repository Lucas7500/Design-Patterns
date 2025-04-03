using Behavioral.Strategy.Interfaces;
using Behavioral.Strategy.Models;
using System.Text.Json;

namespace Behavioral.Strategy
{
    internal class ResourceToJsonStrategy : IResourceGenerationStrategy
    {
        public string Generate(string resourceName)
        {
            return JsonSerializer.Serialize(new Resource(resourceName, "This is a resource in JSON format"));
        }
    }
}
