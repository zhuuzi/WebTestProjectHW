using NUnit.Framework;
using OpenQA.Selenium;
using EpamWebTests.Pages;
using WebTestProject.Drivers;
using EpamWebTests.Utils;

namespace EpamWebTests.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage HomePage;
        protected AboutPage AboutPage;
        protected InsightsPage InsightsPage;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverManager.GetDriver(Constants.Configurations.Headless);
            driver.Navigate().GoToUrl(Constants.Urls.EpamUrl);

            HomePage = new HomePage(driver);
            AboutPage = new AboutPage(driver);
            InsightsPage = new InsightsPage(driver);
            HomePage.AcceptCookies();
        }

        [TearDown]
        public void Teardown()
        {
            WebDriverManager.QuitDriver();
        }
    }
}