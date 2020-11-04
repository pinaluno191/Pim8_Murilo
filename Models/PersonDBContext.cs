using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PimV8.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonPhone>(entity => 
            {
                entity.HasKey(e => new { e.PersonId, e.PhoneId });
            });

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<PersonPhone> PersonPhones { get; set; }
    }
}
