using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReqnrollSeleniumDemo.Utilities
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }
    }
}
