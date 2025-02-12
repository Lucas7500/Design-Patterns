using Creational.Builder.Exceptions;
using Creational.Builder.Interfaces;
using Creational.Builder.Models;

namespace Creational.Builder
{
    internal class PersonBuilder : IPersonBuilder
    {
        private readonly Person _person = new();

        public IPersonBuilder WithName(string name)
        {
            _person.Name = name;
            return this;
        }

        public IPersonBuilder WithBirthDate(DateOnly birthDate)
        {
            _person.BirthDate = birthDate;
            return this;
        }
        
        public IPersonBuilder WithBirthDate(DateTime birthDate)
        {
            _person.BirthDate = DateOnly.FromDateTime(birthDate);
            return this;
        }

        public IPersonBuilder WithEmail(string email)
        {
            _person.Email = email;
            return this;
        }

        public IPersonBuilder WithPhone(string phone)
        {
            _person.Phone = phone;
            return this;
        }
        
        public IPersonBuilder WithOccupation(string occupation)
        {
            _person.Occupation = occupation;
            return this;
        }
        
        public IPersonBuilder WithSalary(decimal salary)
        {
            _person.Salary = salary;
            return this;
        }
        
        public IPersonBuilder WithWife(Person wife)
        {
            _person.Wife = wife;
            return this;
        }

        public Person Build()
        {
            if (string.IsNullOrWhiteSpace(_person.Name))
            {
                throw new MissingRequiredFieldException(nameof(Person.Name));
            }

            if (_person.BirthDate == default)
            {
                throw new MissingRequiredFieldException(nameof(Person.BirthDate));
            }

            if (_person.IsEmployed && _person.Salary == decimal.Zero)
            {
                throw new InvalidPersonException("If a person has an occupation, they must earn a salary!");
            }

            return _person;
        }
    }
}
