using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.EntityFrameworkCore.Tests
{
    public interface IPersonRepository
    {
        ICollection<Person> GetAll();
        void Add(Person person);
    }
}
