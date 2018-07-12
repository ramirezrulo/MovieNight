using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class History : AModel
    {
        public List<Movie> MovieList
        {
            get;
            set;
        }

        public History()
        {
            MovieList = new List<Movie>()
            {
                new Movie()
            };

        }
        public void AddMovie()
        {
            // movieList.Add(new Movie());
        }
    }

}