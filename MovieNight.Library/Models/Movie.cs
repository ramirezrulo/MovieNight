using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Actor> Actors
        {
            get;
            set;
        }

        public EGenre Genre { get; set; }

        public string Title { get; set; }

        public Movie()
        {
            Actors = new List<Actor>()
            {
                new Actor()
            };

            Title = string.Empty;
            Genre = EGenre.Romantic_Western;
        }
    }
}
