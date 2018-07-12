using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class HistoryTests
    {
        [Fact] // On Execut(ing) happens before the thing is called
        public void Test_HistoryID()
        {
            var expected = typeof(Guid);
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_HistoryMovieList()
        {
            var expected = 0;
            var sut = new History();
            //sut.AddMovie();

            var actual = sut.MovieList;
            Assert.True(expected <= actual.Count);
            Assert.True(typeof(List<Movie>) == actual.GetType());
        }



    }
}
