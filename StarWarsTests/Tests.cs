using System;
using System.CodeDom;
using NUnit.Framework;
using StarWarsCode;

namespace StarWarsTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void APICallerShouldReturnText()
        {
            var apiCaller = new ApiCaller();
            var openingCreditsText = apiCaller.GetFilmInfo();
            Assert.That(openingCreditsText, Is.Not.Null);
        }

        [Test]
        public void APICallerShouldGetOpeningCrawlFromFilmInfo()
        {
            var apiCaller = new ApiCaller();
            var openingCrawl = apiCaller.GetOpeningCrawl();
            Assert.That(openingCrawl.Length > 0);
        }

        [Test]
        public void APICallerReturnsOpeningCrawlFromAnyOfThe7FilmsAtRandom()
        {
            var apiCaller = new ApiCaller();
            var openingCrawl = apiCaller.GetOpeningCrawl();
            var anotherOpeningCrawl = apiCaller.GetOpeningCrawl();
            var afurtherOpeningCrawl = apiCaller.GetOpeningCrawl();
            Assert.That(openingCrawl != anotherOpeningCrawl && openingCrawl != afurtherOpeningCrawl);
        }

        [Test]
        public void APICallerReplacesOriginalCharacterNamesWithMeerkats()
        {
            var apiCaller = new ApiCaller();
            Assert.That(apiCaller.GetOpeningCrawl().Contains("Sergei"));
        }
    }
}
