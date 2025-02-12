namespace Creational.Builder.Exceptions
{
    internal class MissingRequiredFieldException(string field) : Exception($"The required field {field} is missing!")
    {
    }
}
