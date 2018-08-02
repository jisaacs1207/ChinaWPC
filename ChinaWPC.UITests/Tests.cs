using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ChinaWPC.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp _app;
        Platform _platform;

        public Tests(Platform platform)
        {
            this._platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            _app = AppInitializer.StartApp(_platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = _app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            _app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }
    }
}
