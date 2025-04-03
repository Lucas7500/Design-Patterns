using Structural.Adapter.Interfaces;
using Structural.Adapter.Models;
using System.Text;

namespace Structural.Adapter
{
    internal class ResourceToTextAdapter : IResourceAdapter
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
