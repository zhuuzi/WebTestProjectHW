using System;
using NUnit.Framework;
using OpenQA.Selenium;
using WebTestProject.Utils;
using WebTestProject.Drivers;

namespace WebTestProject.Tests.Base
{
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverManager.GetDriver();
            driver.Navigate().GoToUrl(TestConstants.LoginUrl);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriver();
        }
    }
}
