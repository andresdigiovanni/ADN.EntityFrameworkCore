using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.EntityFrameworkCore.Tests
{
    public class PersonRepository : IPersonRepository
    {
        private PersonDataContext personDataContext;

        public PersonRepository(PersonDataContext personDataContext)
        {
            this.personDataContext = personDataContext;
        }

        public ICollection<Person> GetAll()
        {
            return personDataContext.People.ToList();
        }

        public void Add(Person person)
        {
            personDataContext.InsertOrUpdate(person);
            personDataContext.SaveChanges();
        }
    }
}
