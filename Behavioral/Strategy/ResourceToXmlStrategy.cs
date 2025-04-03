using Behavioral.Strategy.Interfaces;
using Behavioral.Strategy.Models;
using System.Xml.Serialization;

namespace Behavioral.Strategy
{
    internal class ResourceToXmlStrategy : IResourceGenerationStrategy
    {
        public string Generate(string resourceName)
        {
            var resource = new Resource(resourceName, "This is a resource in XML format");
            var serializer = new XmlSerializer(typeof(Resource));

            using var writer = new StringWriter();
            serializer.Serialize(writer, resource);

            return writer.ToString();
        }
    }
}
