namespace Behavioral.Strategy.Models
{
    public class Resource
    {
        public Resource() { }

        public Resource(string name, string? description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
