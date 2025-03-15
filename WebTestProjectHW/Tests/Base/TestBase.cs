using System;
using NUnit.Framework;
using OpenQA.Selenium;
using WebTestProject.Utils;
using WebTestProject.Drivers;
using WebTestProject.Pages;

namespace WebTestProject.Tests.Base
{
    public class TestBase
    {
        protected IWebDriver driver;
        public LoginPage loginPage;
        public DashboardPage dashboardPage;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverManager.GetDriver();
            driver.Navigate().GoToUrl(TestConstants.LoginUrl);
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriver();
        }
    }
}
