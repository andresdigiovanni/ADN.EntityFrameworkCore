using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.EntityFrameworkCore.Tests
{
    public class PersonDataContext : DbContext
    {
        public PersonDataContext() { }
        public PersonDataContext(DbContextOptions<PersonDataContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
    }
}
