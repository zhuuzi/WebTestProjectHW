using OpenQA.Selenium;
using WebTestProject.Utils;
using System.Collections.Generic;
using WebTestProject.Pages.Components;

namespace WebTestProject.Pages
{
    public class DashboardPage
    {
        private readonly IWebDriver driver;
        private readonly By welcomeMessage = By.XPath("//*[@class='title' and text()='Products']");
        private readonly By cartIcon = By.Id("shopping_cart_container");
        private readonly By sideMenuButton = By.Id("react-burger-menu-btn");
        private readonly By addToCartButtons = By.XPath("//div[@class='inventory_list']//button[contains(@data-test, 'add-to-cart')]");

        private readonly SideBar sideBar;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            this.sideBar = new SideBar(driver);
        }

        public bool IsDashboardLoaded() => WaitHelper.WaitForElement(driver, welcomeMessage) != null;
        public bool IsCartVisible() => WaitHelper.WaitForElement(driver, cartIcon) != null;
        public void OpenSideMenu() => WaitHelper.WaitForElement(driver, sideMenuButton).Click();

        public void Logout()
        {
            OpenSideMenu();
            sideBar.Logout();
        }

        public void AddItemsToCart(int itemCount)
        {
            var buttons = driver.FindElements(addToCartButtons);
            int count = 0;

            foreach (var button in buttons)
            {
                if (count >= itemCount) break;
                button.Click();
                count++;
            }
        }

        public void ProceedToCart()
        {
            WaitHelper.WaitForElement(driver, cartIcon).Click();
        }
    }
}
