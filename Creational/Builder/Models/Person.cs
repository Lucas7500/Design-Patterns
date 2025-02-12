namespace Creational.Builder.Models
{
    internal class Person
    {
        internal string Name { get; set; } = null!;
        internal DateOnly BirthDate { get; set; }
        internal int Age => CalculateAge(BirthDate);
        internal string? Email { get; set; }
        internal string? Phone { get; set; }
        internal string? Occupation { get; set; }
        internal decimal Salary { get; set; }
        internal Person? Wife { get; set; }
        internal bool IsEmployed => !string.IsNullOrWhiteSpace(Occupation);
        internal bool IsMarried => Wife is not null;

        private static int CalculateAge(DateOnly birthDate)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - birthDate.Year;

            if (today < new DateOnly(today.Year, birthDate.Month, birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
