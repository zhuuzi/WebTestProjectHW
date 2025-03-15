using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Pages.Components
{
    public class SideBar
    {
        private readonly IWebDriver driver;
        private readonly By logoutButton = By.XPath("//*[text()='Logout']");

        public SideBar(IWebDriver driver) => this.driver = driver;

        public void Logout()
        {
            WaitHelper.WaitForElement(driver, logoutButton).Click();
        }
    }
}
