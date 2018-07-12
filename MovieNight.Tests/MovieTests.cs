using MovieNight.Library;
using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        private Movie sut; //still a member of the class Im just not instencieted there.

        public MovieTests()
        {
            sut = new Movie();
        }


        [Fact] // On Execut(ing) happens before the thing is called
        public void Test_MovieID()
        {
            var expected = typeof(Guid);
            //var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            //var sut = new Movie();
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }

        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);
            //var sut = new Movie();

            Assert.True(expected == sut.Title.GetType());
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);

            Assert.True(expected == sut.Genre.GetType());

        }
    }
}