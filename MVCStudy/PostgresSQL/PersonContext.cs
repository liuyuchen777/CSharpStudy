using System;
using Microsoft.EntityFrameworkCore;
using MVCStudy.Models;

namespace MVCStudy.PostgresSQL
{
    public class PersonContext : DbContext
    {
        public virtual DbSet<Person> person { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Host=localhost;Database=postgres;Username=postgres;Password=980628");
    }
}
