using NUnit.Framework;
using StarWarsCode;

namespace StarWarsTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WhenMakingAPICallShouldGetFilmOpeningCredits()
        {
            var apiCaller = new ApiCaller();
            var openingCreditsText = apiCaller.GetOpeningCredits();
            Assert.That(openingCreditsText, Is.Not.Null);
        }
    }
}
