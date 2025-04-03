using Behavioral.Strategy.Services;
using Behavioral.Strategy;

try
{
    var resource = new ResourceGenerator(new ResourceToTextStrategy()).Generate("Lucas");

    Console.WriteLine(resource);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}