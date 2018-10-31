using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExerciseNum1.DAL
{
    public class PersonContext
    {
        public PersonContext() : base("PersonContext")
        {
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}