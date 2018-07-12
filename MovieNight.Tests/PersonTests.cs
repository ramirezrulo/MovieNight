using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class PersonTests
    {

        [Fact] // On Execut(ing) happens before the thing is called
        public void Test_PersonID()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
        [Fact]
        public void Test_PersonHistory()
        {
            //sut = subject under test
            //var sut = new Person();
            //Assert.NotNull(sut.History);

            Assert.NotNull(new Person().History);

        }

    }
}