using NUnit.Framework;
using OpenQA.Selenium;
using WebTestProject.Pages;
using WebTestProject.Utils;
using WebTestProject.Tests.Base;

namespace WebTestProject.Tests
{
    public class LoginTests : TestBase
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;

        [SetUp]
        public void TestSetup()
        {
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [Test]
        [TestCase(TestConstants.ValidUsername, TestConstants.ValidPassword, TestName = "ValidLogin")]
        public void TestLogin(string username, string password)
        {
            loginPage.Login(username, password);
            Assert.That(dashboardPage.IsDashboardLoaded(), Is.True);
        }

        [Test]
        [TestCase(TestConstants.InvalidUsername, TestConstants.InvalidPassword, TestName = "InvalidLogin")]
        [TestCase(TestConstants.ValidUsername, TestConstants.InvalidPassword, TestName = "WrongPassword")]
        [TestCase("", "", TestName = "EmptyCredentials")]
        public void TestInvalidLogin(string username, string password)
        {
            loginPage.Login(username, password);
            Assert.That(loginPage.IsErrorDisplayed(), Is.True, "Login should have failed, but it didn't.");
        }

    }
}
