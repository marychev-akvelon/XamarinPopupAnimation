using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace XamarinPopupAnimation.UITest
{
    [TestFixture(Platform.Android)]
    // [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            
            app.WaitForElement(c => c.Marked("Hi"));
            Thread.Sleep(3000);
            app.Tap(c => c.Marked("Hi"));
            app.WaitForElement(c => c.Marked("One"));

            Thread.Sleep(3000);
            app.Tap(c => c.Marked("One"));
        }
    }
}
