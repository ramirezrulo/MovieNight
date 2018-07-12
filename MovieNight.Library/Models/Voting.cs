using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Voting : AModel
    {
        public List<Person> Persons
        {
            get;
            set;
        }
        public Movie Movie = new Movie();
        public Voting()
        {
            Persons = new List<Person>()
            {
                new Person()
            };

        }
    }
}