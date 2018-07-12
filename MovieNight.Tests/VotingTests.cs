using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact] // On Execut(ing) happens before the thing is called
        public void Test_VotingID()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());


        }
        [Fact]
        public void Test_Voting_HasMovie()
        {
            Assert.NotNull(new Voting().Movie);
        }
        [Fact]
        public void Test_Voting_HasVoters()
        {
            var expected = 0;
            var sut = new Voting();
            var actual = sut.Persons;

            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(actual.Count >= expected);

        }
    }
}