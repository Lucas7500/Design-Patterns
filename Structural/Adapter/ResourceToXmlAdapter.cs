using Structural.Adapter.Interfaces;
using Structural.Adapter.Models;
using System.Xml.Serialization;

namespace Structural.Adapter
{
    internal class ResourceToXmlAdapter : IResourceAdapter
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
