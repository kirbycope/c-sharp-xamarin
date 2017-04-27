using AutomationFramework;
using NUnit.Framework;

namespace TimothyCopeAndroid
{
    [TestFixture]
    public class HomePageTests : TestBase
    {
        [Test]
        [Description("An example test for the guide on TimothyCope.com")]
        [TestCaseSource(typeof(TestBase), "GetDevices")]
        public void ExampleTest(string deviceSerial)
        {
            System.Threading.Thread.Sleep(20000);
            // Setup the App on the provided service
            Setup(deviceSerial);
            // Verify the Logo is displayed on the "Home" page
            Assert.IsTrue(App.HomePage.imgLogo.Displayed);
        }
    }
}
