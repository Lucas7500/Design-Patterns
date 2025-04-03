using Structural.Adapter;
using Structural.Adapter.Services;

try
{
    var resource = new ResourceGenerator(new ResourceToTextAdapter()).Generate("Lucas");

    Console.WriteLine(resource);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}