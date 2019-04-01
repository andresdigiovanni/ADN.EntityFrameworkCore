using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace ADN.EntityFrameworkCore.Tests
{
    public class EntityFrameworkCoreUtilsTest
    {
        [Fact]
        public void Insert()
        {
            IPersonRepository sut = GetInMemoryPersonRepository();
            Person person = new Person()
            {
                PersonId = 1,
                FirstName = "Luke",
                Surname = "Skywalker",
            };
            sut.Add(person);

            Person savedPerson = sut.GetAll().FirstOrDefault();

            Assert.Equal(1, sut.GetAll().Count);
            Assert.Equal("Luke", savedPerson.FirstName);
            Assert.Equal("Skywalker", savedPerson.Surname);
        }

        [Fact]
        public void Update()
        {
            IPersonRepository sut = GetInMemoryPersonRepository();
            Person person = new Person()
            {
                PersonId = 1,
                FirstName = "Luke",
                Surname = "Skywalker",
            };
            sut.Add(person);

            person = new Person()
            {
                PersonId = 1,
                FirstName = "Luke",
                Surname = "Sky-walker",
            };
            sut.Add(person);

            Person savedPerson = sut.GetAll().FirstOrDefault();

            Assert.Equal(1, sut.GetAll().Count);
            Assert.Equal("Luke", savedPerson.FirstName);
            Assert.Equal("Sky-walker", savedPerson.Surname);
        }

        private IPersonRepository GetInMemoryPersonRepository()
        {
            var builder = new DbContextOptionsBuilder<PersonDataContext>();
            builder.UseInMemoryDatabase();

            DbContextOptions<PersonDataContext> options;
            options = builder.Options;

            PersonDataContext personDataContext = new PersonDataContext(options);
            personDataContext.Database.EnsureDeleted();
            personDataContext.Database.EnsureCreated();

            return new PersonRepository(personDataContext);
        }
    }
}
