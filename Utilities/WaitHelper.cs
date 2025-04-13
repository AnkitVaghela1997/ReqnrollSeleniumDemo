using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ReqnrollSeleniumDemo.Utilities
{
    public class WaitHelper
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public WaitHelper(IWebDriver driver, int timeoutInSeconds = 10)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
        }

        public IWebElement WaitForElement(By locator)
        {
            return _wait.Until(driver => driver.FindElement(locator));
        }
    }
}
