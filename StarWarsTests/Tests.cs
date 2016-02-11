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
            Assert.That(openingCrawl.Contains("Empire"));
        }
    }
}
