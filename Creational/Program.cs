using Creational.Builder;

try
{
    var person = new PersonBuilder()
        .WithName("Lucas")
        .WithBirthDate(new DateOnly(2005, 04, 27))
        .WithOccupation("Desenvolvedor de Software")
        .WithSalary(3000)
        .WithWife(new())
        .Build();

    Console.WriteLine(person.Name);
    Console.WriteLine(person.BirthDate);
    Console.WriteLine(person.Age);
    Console.WriteLine(person.Age);
    Console.WriteLine(person.Occupation);
    Console.WriteLine(person.Salary);
    Console.WriteLine(person.IsEmployed);
    Console.WriteLine(person.IsMarried);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}