using NUnit.Framework;
using WebTestProject.Tests.Base;
using WebTestProject.Pages;
using WebTestProject.Utils;
using OpenQA.Selenium;


namespace WebTestProject.Tests
{
    public class DashboardTests : TestBase
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;


        [SetUp]
        public void TestSetup()
        {
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            loginPage.Login(TestConstants.ValidUsername, TestConstants.ValidPassword);
        }

        [Test]
        public void TestDashboardLoad()
        {
            Assert.That(dashboardPage.IsDashboardLoaded(), Is.True, "Dashboard did not load properly.");
        }

        [Test]
        public void TestCartIconVisible()
        {
            Assert.That(dashboardPage.IsCartVisible(), Is.True, "Cart icon is not visible.");
        }

        [Test]
        public void TestLogout()
        {
            dashboardPage.Logout();
            Assert.That(loginPage.IsLoginPageVisible(), Is.True, "Logout failed.");
        }
    }
}
