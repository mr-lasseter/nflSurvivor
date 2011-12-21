using System;
using NUnit.Framework;
using NflSurvivior.Core.Tasks;
using StructureMap.AutoMocking;
using FluentAssertions;

namespace NflSurvivor.Core.Specs.Tasks
{
    public class EspnFeedServiceSpecs
    {

        [TestFixture]
        public class When_getting_the_feed_from_ESPN
        {

            [Test]
            public void Should_return_the_feed_from_the_service()
            {
                var service = new EspnFeedService();
                var scoreBoard = service.GetScoreBoard();

                Console.WriteLine(scoreBoard);

                scoreBoard.Should().StartWith("&nfl_s_delay");
            }
        }
    }
}