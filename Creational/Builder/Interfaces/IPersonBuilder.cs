using Creational.Builder.Models;

namespace Creational.Builder.Interfaces
{
    internal interface IPersonBuilder
    {
        IPersonBuilder WithName(string name);
        IPersonBuilder WithBirthDate(DateOnly birthDate);
        IPersonBuilder WithBirthDate(DateTime birthDate);
        IPersonBuilder WithEmail(string email);
        IPersonBuilder WithPhone(string phone);
        IPersonBuilder WithOccupation(string occupation);
        IPersonBuilder WithSalary(decimal salary);
        IPersonBuilder WithWife(Person wife);
        Person Build();
    }
}
