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
            var openingCreditsText = apiCaller.GetOpeningCredits();
            Assert.That(openingCreditsText, Is.Not.Null);
        }

        [Test]
        public void APICallerShouldReturnStarWarsOpeningCredits()
        {
            var apiCaller = new ApiCaller();
            var openingCreditsText = apiCaller.GetOpeningCredits();
            Assert.That(openingCreditsText.Contains("Empire"));
        }
    }
}
