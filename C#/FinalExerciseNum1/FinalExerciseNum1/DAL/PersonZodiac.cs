using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinalExerciseNum1.Models;

namespace FinalExerciseNum1.DAL
{
    public class PersonZodiac : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var persons = new List<Person>
            {
                new Person{ID=1000000, FirstName="Steffan", LastName="del Prado", BirthDate=DateTime.Parse("1986-12-28"), BirthPlace="Misawa", Gender="male"},
            };

            persons.ForEach(p => context.Person.Add());
            context.SaveChanges();
        }
    }
}