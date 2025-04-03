using Behavioral.Strategy.Interfaces;
using Behavioral.Strategy.Models;
using System.Text;

namespace Behavioral.Strategy
{
    internal class ResourceToTextStrategy : IResourceGenerationStrategy
    {
        public string Generate(string resourceName)
        {
            var resource = new Resource(resourceName, "This is a resource in plain text format");

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Name: {resource.Name}");
            stringBuilder.AppendLine($"Description: {resource.Description}");

            return stringBuilder.ToString();
        }
    }
}
