using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class PersonDBContext:DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options):base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Phone> Phone{ get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Type> Type { get; set; }




    }
}
