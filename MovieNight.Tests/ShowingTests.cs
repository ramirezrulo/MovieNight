using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class ShowingTests
    {
        [Fact] // On Execut(ing) happens before the thing is called
        public void Test_ShowingID()
        {
            var expected = typeof(Guid);
            var sut = new Showing();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_ShowingMovies()
        {
            var expected = 0;
            var sut = new Showing();
            //sut.AddMovie();

            var actual = sut.Movies;
            Assert.True(expected <= actual.Count);
            Assert.True(typeof(List<Movie>) == actual.GetType());
        }
    }
}