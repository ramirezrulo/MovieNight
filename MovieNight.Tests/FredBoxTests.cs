using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class FredBoxTests
{
    private FredBox sut;

    public FredBoxTests()
    {
        sut = new FredBox();
    }
        //public DistributeMovies()
        //{
        //    sut = new FredBox();
        //}

        [Fact]
    public void Test_FredBoxMakeMovie()
    {
        var expected = "My First Movie";
        var actual = sut.MakeMovie(expected);

        Assert.True(expected == actual.Title);
    }

        [Fact]
        public void Test_FredBoxGetMovies()
        {
            var expected = 0;
            var actual = sut.GetMovies();

            Assert.True(expected <= actual.Count());
        }

        [Fact]
        public void Test_FredBoxDistributeMovie()
        {
            var title = "My Second Movie";
            var expected = sut.GetMovies();

          sut.DistributeMovies(sut.MakeMovie(title));
          
         Assert.True(expected.Count() == sut.GetMovies().Count());   
        }
    }
}
